using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhamsaCourseProject.Areas.Admin.Filters;
using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Dtos;
using System.Globalization;

namespace KhamsaCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(IncludeRoles))]
    public class HomeController : Controller
    {
        private readonly AdminContext _db;
        public HomeController(AdminContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            List<HomeDto> data = (from sector in _db.Sectors.Where(a => a.IsActive == 1).ToList()
                                  select new HomeDto
                                  {
                                      Id = sector.Id,
                                      StudentCount = _db.Students.Where(a => a.IsActive == 1 && a.SectorId == sector.Id).ToList().Count,
                                      SectorName = sector.Name
                                  }).ToList();
            return View(data);
        }
        public IActionResult StudentCounts()
        {
            CultureInfo ci = new CultureInfo("az-Latn-AZ");
            var studentCounts = _db.Students.Where(a=>a.RegistrationDate > DateTime.Now.AddMonths(-5)).GroupBy(o => new
            {
                Month = o.RegistrationDate.Month,
                Year = o.RegistrationDate.Year
            })
              .Select(g => new
              {
                  Month = new DateTime(g.Key.Year, g.Key.Month,1).ToString("MMMM", ci),
                  Total = g.Count()
              });
            return Json(studentCounts);
        }
        public IActionResult OfficeCounts()
        {
            CultureInfo ci = new CultureInfo("az-Latn-AZ");
            var studentCounts = _db.Offices.Where(a => a.CostDate > DateTime.Now.AddMonths(-3)).GroupBy(o => new
            {
                Month = o.CostDate.Month,
                Year = o.CostDate.Year
            })
              .Select(g => new
              {
                  Month = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMMM", ci),
                  Total = g.Count()
              });
            return Json(studentCounts);
        }

    }
}
