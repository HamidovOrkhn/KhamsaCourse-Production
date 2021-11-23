using KhamsaCourseProject.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhamsaCourseProject.Areas.Admin.Models;
using KhamsaCourseProject.Areas.Admin.Filters;

namespace KhamsaCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(IncludeRoles))]
    public class SectorController : Controller
    {
        private readonly AdminContext _context;

        public SectorController(AdminContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            int id = Convert.ToInt32(HttpContext.Request.Cookies["uid"]);
            List<Sector> sectors = (from role in _context.Roles.Where(a=>a.UserId == id && a.TypeId == 1)
                                   join sector in _context.Sectors.Where(a => a.IsActive == 1) on role.ActivityId equals sector.Id
                                   select new Sector
                                   {
                                       Email = sector.Email,
                                       Fax = sector.Fax,
                                       Name = sector.Name,
                                       Phone = sector.Phone,
                                       Id = sector.Id,
                                       IsActive = sector.IsActive
                                   }).ToList();
            return View(sectors);
        }
        public IActionResult Details(int id)
        {
            return View(_context.Sectors.Where(a => a.IsActive == 1 && a.Id == id).FirstOrDefault());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Sector sector)
        {
            sector.IsActive = 1;
            _context.Sectors.Add(sector);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Sector sector = _context.Sectors.Where(a => a.Id == id).FirstOrDefault();
            if (sector is object)
            {
                _context.Sectors.Remove(sector);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
