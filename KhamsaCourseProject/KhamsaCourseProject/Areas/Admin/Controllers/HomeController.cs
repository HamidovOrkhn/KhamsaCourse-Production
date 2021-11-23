using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhamsaCourseProject.Areas.Admin.Filters;
using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Dtos;

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

    }
}
