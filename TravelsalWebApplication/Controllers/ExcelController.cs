using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelsalWebApplication.Models;

namespace TravelsalWebApplication.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticExcel()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Page1");
            workSheet.Cells[1, 1].Value = "Destination";
            workSheet.Cells[1, 2].Value = "Guide";
            workSheet.Cells[1, 3].Value = "Capacity";

            workSheet.Cells[2, 1].Value = "Georgia";
            workSheet.Cells[2, 2].Value = "Ivanna";
            workSheet.Cells[2, 3].Value = "5";

            workSheet.Cells[3, 1].Value = "Azerbaijan";
            workSheet.Cells[3, 2].Value = "Peterson";
            workSheet.Cells[3, 3].Value = "10";

            var bytes = excel.GetAsByteArray();

            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","file1.xlsx");
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using(var c=new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight=x.DayNight,
                    Capacity=x.Capacity,
                    Price=x.Price
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult DestinationExcelReport()
        {
            using(var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tour List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Duration";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DestinationList.xlsx");
                }
            }
        }
    }
}
