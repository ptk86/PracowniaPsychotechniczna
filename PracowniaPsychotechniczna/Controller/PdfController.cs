
using System;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Pages.Faktura;
using PracowniaPsychotechniczna.Services;

namespace PracowniaPsychotechniczna.Controller
{
    [Route("api/pdf")]
    public class PdfController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IConverter _pdfConverter;
        private readonly ApplicationContext _context;
        private readonly IViewRenderService _renderService;

        public PdfController(IConverter pdfConverter, ApplicationContext context, IViewRenderService renderService)
        {
            _pdfConverter = pdfConverter;
            _context = context;
            _renderService = renderService;
        }

        [HttpGet("faktura")]
        public IActionResult Faktura()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    PaperSize = PaperKind.A3,
                    Orientation = Orientation.Landscape,
                },

                Objects = {
                   new ObjectSettings()
                    {
                        Page = "https://github.com/",

                    }
                }
            };

            var pdf = _pdfConverter.Convert(doc);

            return new FileContentResult(pdf, "aplication/pdf");
        }

        [HttpGet("Test")]
        public async Task<IActionResult> Test(int id)
        {
            var firma = _context.Firma.Include(f => f.FirmaBadanieList)
                .ThenInclude(fb => fb.Badanie)
                .ThenInclude(fb => fb.Badany)
                .Include(f => f.FirmaBadanieList)
                .ThenInclude(fb => fb.Badanie)
                .ThenInclude(fb => fb.TypBadania)
                .FirstOrDefault(f => f.Id == id);

            var faktura = new CreateFaktura
            {
                Sprzedawca = new Firma
                {
                    Nazwa = "CBMP Piotr Kiliński",
                    Adres = "ul. Irzykowskiego 3/24, 42-207 Częstochowa",
                    Nip = "9492000541"
                },
                Nabywca = new Firma
                {
                    Id = firma.Id,
                    Nazwa = firma.Nazwa,
                    Adres = firma.Adres,
                    Nip = firma.Nip
                },
                Badania = firma.FirmaBadanieList.Select(fb => new Badanie
                {
                    Id = fb.BadanieId,
                    Imie = fb.Badanie.Badany.Imie,
                    Nazwisko = fb.Badanie.Badany.Nazwisko,
                    Typ = fb.Badanie.TypBadania.Nazwa,
                    Cena = fb.Badanie.TypBadania.Cena,
                }).OrderByDescending(b => b.Cena).ToList()
            };

            var htmlString = await _renderService.RenderToStringAsync("Pdf/Test", faktura);

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    PaperSize = PaperKind.A3,
                    Orientation = Orientation.Landscape,
                },

                Objects = {
                    new ObjectSettings()
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