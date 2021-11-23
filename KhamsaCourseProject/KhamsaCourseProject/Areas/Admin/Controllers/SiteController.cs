using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Filters;
using KhamsaCourseProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(IncludeRoles))]
    public class SiteController : Controller
    {
        public readonly AdminContext _db;
        public SiteController(AdminContext db)
        {
            _db = db;
        }
        #region StudentClasses
        public IActionResult IndexClass()
        {
            return View(_db.StudentClasses.ToList());
        }
        [HttpGet]
        public IActionResult CreateClass()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClass(StudentClass request)
        {
            _db.StudentClasses.Add(request);
            _db.SaveChanges();
            return RedirectToAction("IndexClass");
        }
        [HttpGet]
        public IActionResult EditClass(int id)
        {
            StudentClass dt = new StudentClass();
            if (dt is object)
            {
                dt = _db.StudentClasses.Where(a => a.Id == id).FirstOrDefault();
            }
            return View(dt);
        }
        [HttpPost]
        public IActionResult EditClass(int id,StudentClass request)
        {
            StudentClass dt = _db.StudentClasses.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                dt.Name = request.Name;
                _db.SaveChanges();
            }
            return RedirectToAction("IndexClass");
        }
        [HttpGet]
        public IActionResult DeleteClass(int id)
        {
            StudentClass dt = _db.StudentClasses.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                _db.StudentClasses.Remove(dt);
                _db.SaveChanges();
            }
            return RedirectToAction("IndexClass");
        }
        #endregion
        #region StudentGroups
        public IActionResult IndexGroup()
        {
            return View(_db.StudentGroups.ToList());
        }
        [HttpGet]
        public IActionResult CreateGroup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateGroup(StudentGroup request)
        {
            _db.StudentGroups.Add(request);
            _db.SaveChanges();
            return RedirectToAction("IndexGroup");
        }
        [HttpGet]
        public IActionResult EditGroup(int id)
        {
            StudentGroup dt = new StudentGroup();
            if (dt is object)
            {
                dt = _db.StudentGroups.Where(a => a.Id == id).FirstOrDefault();
            }
            return View(dt);
        }
        [HttpPost]
        public IActionResult EditGroup(int id, StudentGroup request)
        {
            StudentGroup dt = _db.StudentGroups.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                dt.Name = request.Name;
                _db.SaveChanges();
            }
            return RedirectToAction("IndexGroup");
        }
        [HttpGet]
        public IActionResult DeleteGroup(int id)
        {
            StudentGroup dt = _db.StudentGroups.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                _db.StudentGroups.Remove(dt);
                _db.SaveChanges();
            }
            return RedirectToAction("IndexGroup");
        }
        #endregion
        #region StudentTypes
        public IActionResult IndexType()
        {
            return View(_db.StudentTypes.ToList());
        }
        [HttpGet]
        public IActionResult CreateType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateType(StudentType request)
        {
            _db.StudentTypes.Add(request);
            _db.SaveChanges();
            return RedirectToAction("IndexType");
        }
        [HttpGet]
        public IActionResult EditType(int id)
        {
            StudentType dt = new StudentType();
            if (dt is object)
            {
                dt = _db.StudentTypes.Where(a => a.Id == id).FirstOrDefault();
            }
            return View(dt);
        }
        [HttpPost]
        public IActionResult EditType(int id, StudentType request)
        {
            StudentType dt = _db.StudentTypes.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                dt.Name = request.Name;
                _db.SaveChanges();
            }
            return RedirectToAction("IndexType");
        }
        [HttpGet]
        public IActionResult DeleteType(int id)
        {
            StudentType dt = _db.StudentTypes.Where(a => a.Id == id).FirstOrDefault();
            if (dt is object)
            {
                _db.StudentTypes.Remove(dt);
                _db.SaveChanges();
            }
            return RedirectToAction("IndexType");
        }
        #endregion
    }
}
