using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Dtos;
using KhamsaCourseProject.Areas.Admin.Helpers;
using KhamsaCourseProject.Areas.Admin.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KhamsaCourseProject.Areas.Admin.Filters;

namespace KhamsaCourseProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(IncludeRoles))]
    public class StudentController : Controller
    {
        private readonly AdminContext _db;
        public StudentController(AdminContext db)
        {
            _db = db;
        }
        public IActionResult Index
            (
            int id,
            [FromQuery] string Fullname,
            [FromQuery] int page = 0,
            [FromQuery] int StudentClasses = 0,
            [FromQuery] int StudentGroups = 0,
            [FromQuery] int StudentTypes = 0,
            [FromQuery] int Status = 0,
            [FromQuery] int PayMonth = 0,
            [FromQuery] int StudentLessonSector = 0
            )
        {
            StudentIndexDto model = new StudentIndexDto();

            model.StudentGroups = _db.StudentGroups.ToList();
            model.StudentClasses = _db.StudentClasses.ToList();
            model.StudentTypes = _db.StudentTypes.ToList();
            model.StudentLessonSectors = _db.StudentLessonSectors.ToList();
            List<Student> data = ExConverter.Filterize(_db, Fullname, id ,StudentClasses, StudentGroups, StudentTypes, Status, PayMonth, StudentLessonSector).OrderBy(a=>a.RegistrationDate).ToList();

            float pagecount = data.Count;

            int count = (int)Math.Ceiling(pagecount / 10);

            data = (data).Skip(page * 10).Take(10).ToList();

            model.Students = data;
            model.StudentCount = _db.Students.Count();
            model.Pagination = ExConverter.PaginationMethod(page, count);

            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            StudentCreateDto model = new StudentCreateDto();

            StudentContract contract = _db.Contracts.Where(a => a.StudentId == id).FirstOrDefault();

            Student student = _db.Students.Where(a => a.Id == id).FirstOrDefault();

            #region Additional Mapping
            model.Id = id;
            model.Fullname = student.Fullname;
            model.HomeNumber = student.HomeNumber;
            model.MobileNumber = student.MobileNumber;
            model.RegistrationDate = student.RegistrationDate;
            model.SectorId = student.SectorId;
            model.StudentClassId = student.StudentClassId;
            model.StudentGroupId = student.StudentGroupId;
            model.StudentTypeId = student.StudentTypeId;
            model.StudentLessonSectorId = student.StudentLessonSectorId;
            model.ContractType = contract.ContractTypeId;
            model.ContractDate = student.RegistrationDate;
            model.ContractId = contract.Id;
            model.Discount = (int)contract.Discount;
            model.Value = (int)contract.Value;
            model.StudentGroups = _db.StudentGroups.ToList();
            model.StudentClasses = _db.StudentClasses.ToList();
            model.StudentTypes = _db.StudentTypes.ToList();
            model.StudentLessonSectors = _db.StudentLessonSectors.ToList();
            model.Sectors = _db.Sectors.Where(a => a.IsActive == 1).ToList();
            model.ContractTypes = _db.ContractTypes.ToList();
            model.Contract = contract;
            #endregion

            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student student = _db.Students.Where(a => a.Id == id).FirstOrDefault();

            _db.Students.Remove(student);

            _db.SaveChanges();

            return RedirectToAction("Index", new { id = student.SectorId }); 
        }
        [HttpPost]
        public IActionResult Edit(StudentCreateDto request, int id)
        {
            Student student = _db.Students.Where(a => a.Id == id).FirstOrDefault();

            StudentContract contract = _db.Contracts.Where(a => a.StudentId == id).FirstOrDefault();

            #region Additional Mapping
            student.Fullname = request.Fullname;
            student.HomeNumber = request.HomeNumber;
            student.MobileNumber = request.MobileNumber;
            student.RegistrationDate = request.RegistrationDate;
            student.SectorId = request.SectorId;
            student.StudentClassId = request.StudentClassId;
            student.StudentGroupId = request.StudentGroupId;
            student.StudentLessonSectorId = request.StudentLessonSectorId;
            student.StudentTypeId = request.StudentTypeId;
            contract.ContractTypeId = request.ContractType;
            contract.ContractDate = request.RegistrationDate;
            contract.Value = request.Value;
            contract.Discount = request.Discount;
            #endregion

            _db.SaveChanges();

            return RedirectToAction("Index", new { id = student.SectorId });
        }
        public IActionResult Activate(int id)
        {
            Student st =_db.Students.Where(a => a.Id == id).FirstOrDefault();
            st.IsActive = 1;
            _db.SaveChanges();
            return RedirectToAction("Index", new { id = st.SectorId });
        }
        public IActionResult Deactivate(int id)
        {
            Student st = _db.Students.Where(a => a.Id == id).FirstOrDefault();
            st.IsActive = 0;
            _db.SaveChanges();
            return RedirectToAction("Index", new { id = st.SectorId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            StudentCreateDto model = new StudentCreateDto();

            model.StudentGroups = _db.StudentGroups.ToList();
            model.StudentClasses = _db.StudentClasses.ToList();
            model.StudentTypes = _db.StudentTypes.ToList();
            model.StudentLessonSectors = _db.StudentLessonSectors.ToList();
            model.Sectors = _db.Sectors.Where(a => a.IsActive == 1).ToList();
            model.ContractTypes = _db.ContractTypes.ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(StudentCreateDto request)
        {
            #region Mapping StudentValue
            Student student = request.Adapt(request);

            double discount = ExConverter.DiscountedValue(request.DiscountType, request.Value, request.Discount);
            StudentContract contract = new StudentContract
            {
                ContractDate = request.RegistrationDate,
                ContractTypeId = request.ContractType,
                Discount = request.Value - discount,
                Value = discount,
                Debt = discount
            };
            student.IsActive = 1;
            #endregion

            _db.Contracts.Add(contract);

            contract.Student = student;

            _db.SaveChanges();

            return RedirectToAction("Index", new { id = student.SectorId });
        }
        public IActionResult Details(int id, [FromQuery] string daterange)
        {
            StudentContract contract = _db.Contracts.Where(a => a.StudentId == id).FirstOrDefault();

            var dateFrom = DateTime.Now.AddDays(-1);
            var dateTo = DateTime.Now.AddDays(1);

            if (!string.IsNullOrEmpty(daterange))
            {
                string[] dateFull = daterange.Split("-");
                dateFrom = Convert.ToDateTime(dateFull[0]);
                dateTo = Convert.ToDateTime(dateFull[1]);
            }

            object payments = _db.Payments.Where(a => a.ProcessId == id && a.CategoryId == 10 && a.PaymentDate >= dateFrom && a.PaymentDate <= dateTo
            ).ToList().Select(a => new PaymentModalDto
            {
                Id = a.Id,
                PaymentDate = a.PaymentDate.ToString("yyyy-MMM-dd HH:mm"),
                Value = a.Value,
                ContractValue = contract.Value
            }).ToList();

            return Json(new
            {
                payments = payments,
                datefrom = dateFrom.ToString("MM/dd/yyyy"),
                dateto = dateTo.ToString("MM/dd/yyyy"),
                id = id
            });

        }
        [HttpGet]
        public IActionResult PayContract(int id)
        {
            StudentPayDto model = new StudentPayDto
            {
                Contract = _db.Contracts
                .Where(a => a.StudentId == id)
                .Include(a => a.Student)
                .FirstOrDefault()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult PayContract(StudentPayDto payment, int id)
        {
            Student student = _db.Students.Where(a => a.Id == id).FirstOrDefault();

            if (student is null)
            {
                TempData["Student-Pay-Error"] = "Belə bir Tələbə Yoxdur";
                return RedirectToAction("Index", "Home");
            }

            StudentContract contract = _db.Contracts.Where(a => a.StudentId == id).FirstOrDefault();

            if (contract is null)
            {
                TempData["Student-Pay-Error"] = "Müqavilə tapılmadı";
                return RedirectToAction("Index", new { id = student.SectorId });
            }
            
            #region Mapping Specify
            contract.Debt = contract.Debt - payment.Value;

            StudentPayment studentPayment = payment.Adapt<StudentPayment>();

            studentPayment.CategoryId = 10;

            studentPayment.PaymentTypeId = 2;

            studentPayment.ProcessId = id;

            studentPayment.SectorId = student.SectorId;

            #endregion

            _db.Payments.Add(studentPayment);

            _db.SaveChanges();

            return RedirectToAction("GetCheck", new { id = studentPayment.Id });

        }
        public IActionResult GetCheck(int id)
        {
            CheckDto model = new CheckDto();
            StudentPayment payment = _db.Payments.Where(a => a.Id == id).FirstOrDefault();
            Student student = _db.Students.Where(a => a.Id == payment.ProcessId).FirstOrDefault();
            if (payment is object && student is object)
            {
                Check chck = _db.Checks.Where(a => a.PaymentId == payment.Id && a.CategoryId == payment.CategoryId).FirstOrDefault();
                if (chck is null)
                {
                    _db.Checks.Add(new Check { CategoryId = payment.CategoryId, CheckDate = DateTime.Now, PaymentId = payment.Id, PaymentDate = payment.PaymentDate });
                    _db.SaveChanges();
                }
                model.Student = student;
                model.Contract = _db.Contracts.Where(a => a.StudentId == payment.ProcessId).FirstOrDefault();
                model.Payment = payment;
                model.Sector = _db.Sectors.Where(a => a.Id == student.SectorId).FirstOrDefault();
            }
            return View(model);
        }
    }
}
