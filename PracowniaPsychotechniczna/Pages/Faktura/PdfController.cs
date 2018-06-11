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

        [HttpGet("pdf")]
        public async Task<IActionResult> FakturaPdf(int id)
        {
            var firma = _context.Firma.Include(f => f.FirmaBadanieList)
                .ThenInclude(fb => fb.Badanie)
                .ThenInclude(fb => fb.Badany)
                .Include(f => f.FirmaBadanieList)
                .ThenInclude(fb => fb.Badanie)
                .ThenInclude(fb => fb.TypBadania)
                .FirstOrDefault(f => f.Id == id);

            var faktura = new Faktura
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