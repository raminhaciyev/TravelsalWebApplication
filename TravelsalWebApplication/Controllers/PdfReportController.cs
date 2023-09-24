using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TravelsalWebApplication.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPDF()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFreport/"+"test1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal PDF Report");
            document.Add(paragraph);
            document.Close();
            return File("/PDFreport/test1.pdf","application/pdf","test1.pdf");
        }

        public IActionResult StaticPDFTable()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PDFreport/" + "test2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Name");
            pdfPTable.AddCell("Surname");
            pdfPTable.AddCell("Gender");

            pdfPTable.AddCell("Ramin");
            pdfPTable.AddCell("Hajiyev");
            pdfPTable.AddCell("male");

            pdfPTable.AddCell("Sultan");
            pdfPTable.AddCell("Sultanova");
            pdfPTable.AddCell("female");

            document.Add(pdfPTable);
            document.Close();
            return File("/PDFreport/test2.pdf", "application/pdf", "test2.pdf");
        }
    }
}
