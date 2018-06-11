using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Services;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    [Route("faktura")]
    public class FakturaController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IConverter _pdfConverter;
        private readonly ApplicationContext _context;
        private readonly IViewRenderService _renderService;

        public FakturaController(IConverter pdfConverter, ApplicationContext context, IViewRenderService renderService)
        {
            _pdfConverter = pdfConverter;
            _context = context;
            _renderService = renderService;
        }

        [HttpGet("pdf")]
        public async Task<IActionResult> Pdf(int fakturaId)
        {
            var dbFaktura = await _context.Faktura.Include(f => f.FakturaBadanieList)
                                                    .ThenInclude(fb => fb.Badanie.FirmaBadanie.Firma)
                                                .Include(f => f.FakturaBadanieList)
                                                    .ThenInclude(fb => fb.Badanie.TypBadania)
                                                .Include(f => f.FakturaBadanieList)
                                                    .ThenInclude(fb => fb.Badanie.Badany)
                                                .Include(f => f.FakturaBadanieList)
                                                      .ThenInclude(fb => fb.Badanie.FirmaBadanie)
                                                      .ThenInclude(fb => fb.Firma)
                                                .FirstOrDefaultAsync(f => f.Id == fakturaId);

            if (dbFaktura == null)
            {
                return BadRequest("Faktura not found!");
            }

            var faktura = new Faktura
            {
                Id = dbFaktura.Id,
                Sprzedawca = new Firma
                {
                    Nazwa = "CBMP Piotr Kiliński",
                    Adres = "ul. Irzykowskiego 3/24, 42-207 Częstochowa",
                    Nip = "9492000541"
                },
                Nabywca = new Firma
                {
                    Id = dbFaktura.FakturaBadanieList.First().Badanie.FirmaBadanie.Firma.Id,
                    Nazwa = dbFaktura.FakturaBadanieList.First().Badanie.FirmaBadanie.Firma.Nazwa,
                    Adres = dbFaktura.FakturaBadanieList.First().Badanie.FirmaBadanie.Firma.Adres,
                    Nip = dbFaktura.FakturaBadanieList.First().Badanie.FirmaBadanie.Firma.Nip
                },
                Badania = dbFaktura.FakturaBadanieList.Select(fb => new Badanie
                {
                    Id = fb.Badanie.Id,
                    Imie = fb.Badanie.Badany.Imie,
                    Nazwisko = fb.Badanie.Badany.Nazwisko,
                    Cena = fb.Badanie.TypBadania.Cena,
                    Typ = fb.Badanie.TypBadania.Nazwa
                }).OrderByDescending(b => b.Cena).ToList()
            }; 


            var htmlString = await _renderService.RenderToStringAsync("Pdf/Faktura", faktura);

            var doc = new HtmlToPdfDocument
            {
                Objects = {
                    new ObjectSettings
                    {
                        HtmlContent = htmlString,
                        WebSettings = new WebSettings
                        {
                            DefaultEncoding = "UTF-8"
                        }
                    }
                }
            };

            var pdf = _pdfConverter.Convert(doc);

            return File(pdf, "applicaiton/pdf", "faktura.pdf");
        }
    }
}