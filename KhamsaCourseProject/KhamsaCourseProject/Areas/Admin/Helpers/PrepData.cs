using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Helpers
{
    public static class PrepData
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            using (var scope = applicationBuilder.ApplicationServices.CreateScope())
            {
                AdminContext _db = scope.ServiceProvider.GetRequiredService<AdminContext>();
                SeedData(_db);
            }

        }
        public static void SeedData(AdminContext db)
        {
            if (!db.StudentClasses.Any())
            {
                db.StudentClasses.Add(new StudentClass { Name = "1-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "2-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "3-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "4-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "5-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "6-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "7-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "8-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "9-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "10-ci sinif" });
                db.StudentClasses.Add(new StudentClass { Name = "11-ci sinif" });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.StudentClasses)}");
            }
            if (!db.StudentGroups.Any())
            {
                db.StudentGroups.AddRange(new List<StudentGroup>() {
                new StudentGroup{ Name = "1-ci qrup" },
                new StudentGroup{ Name = "2-ci qrup" },
                new StudentGroup{ Name = "3-ci qrup" },
                new StudentGroup{ Name = "4-ci qrup" }
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.StudentGroups)}");
            }
            if (!db.StudentTypes.Any())
            {
                db.StudentTypes.AddRange(new List<StudentType>() {
                new StudentType{ Name = "Abituryent" },
                new StudentType{ Name = "Magistr" },
                new StudentType{ Name = "Ibtidai sinif" }
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.StudentTypes)}");
            }
            if (!db.Sectors.Any())
            {
                db.Sectors.Add(new Sector { Name = "Xırdalan", IsActive = 1, Email = "TestEmail", Fax = "TestFax", Phone = "TestPhone" });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.Sectors)}");
            }
            if (!db.PaymentTypes.Any())
            {
                db.PaymentTypes.AddRange(new List<PaymentType>() {
                 new PaymentType { Name = "Gəlir" },
                   new PaymentType { Name = "Zərər" }
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.PaymentTypes)}");
            }
            if (!db.PaymentCategories.Any())
            {
                db.PaymentCategories.AddRange(new List<PaymentCategory>() {
                    new PaymentCategory { Name = "Tələbədən Gəlir" },
                    new PaymentCategory { Name = "İmtahandan Gəlir" },
                    new PaymentCategory { Name = "Nəşriyyatdan Gəlir" },
                    new PaymentCategory { Name = "Əlavə Gəlir" },
                    new PaymentCategory { Name = "Əlavə Xərc" },
                    new PaymentCategory { Name = "Ofis Xərc" },
                    new PaymentCategory { Name = "Pul Çıxışı" },
                    new PaymentCategory { Name = "İşci Çıxışı" },
                    new PaymentCategory { Name = "İşci Alışı" },
                    new PaymentCategory { Name = "Maaş" },
                    new PaymentCategory { Name = "Digər" }
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.PaymentCategories)}");
            }
            if (!db.ContractTypes.Any())
            {
                db.ContractTypes.AddRange(new List<ContractType>() {
                    new ContractType { Name = "Yeni" }
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.ContractTypes)}");
            }
            if (!db.Activities.Any())
            {
                var acts = new List<Activity>();
                db.Activities.Add(new Activity { Name = "Hesabatlar" });
                db.Activities.Add(new Activity { Name = "İstifadəçi Qeydiyyatı" });
                db.Activities.Add(new Activity { Name = "İstifadəçi Siyahısı" });
                db.Activities.Add(new Activity { Name = "Filial Silmə" });
                db.Activities.Add(new Activity { Name = "Sayt Idarəsi" });
                db.Activities.Add(new Activity { Name = "Çeklər" });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.ContractTypes)}");
            }
            if (!db.EmployeeTypes.Any())
            {
                db.EmployeeTypes.AddRange(new List<EmployeeType>() {
                    new EmployeeType { Name = "Ofis İşcisi" },
                    new EmployeeType { Name = "Müəllim"}
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.ContractTypes)}");
            }
            db.SaveChanges();
            if (!db.Users.Any())
            {
                List<Activity> activities = db.Activities.ToList();
                List<Sector> sectors = db.Sectors.ToList();
                List<Role> roles = new List<Role>();
                User user = new User
                {
                    Email = "orxan.hamidov.orxan.hamidov@mail.ru",
                    MobileNumber = "(050) 630 - 8522",
                    Name = "Orxan",
                    Surname = "Hamidov",
                    Password = CryptoHelper.Crypto.HashPassword("adminaz12345"),
                    Permission = "Admin",
                    Username = "orxan.admin"
                };
                db.Users.Add(user);
                db.SaveChanges();
                if (activities.Count > 0)
                {
                    foreach (var item in activities)
                    {
                        roles.Add(new Role { ActivityId = item.Id, TypeId = 2, UserId = user.Id });
                    }
                }
                if (sectors.Count > 0)
                {
                    foreach (var item in sectors)
                    {
                        roles.Add(new Role { ActivityId = item.Id, TypeId = 1, UserId = user.Id });
                    }
                }
                if (roles.Count > 0)
                {
                    db.Roles.AddRange(roles);
                }
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.Users)}");
            }
            if (!db.StudentLessonSectors.Any())
            {
                db.StudentLessonSectors.AddRange(new List<StudentLessonSector>() {
                    new StudentLessonSector { Name = "Az Sektor" },
                    new StudentLessonSector { Name = "Rus Sektor"}
                });
            }
            else
            {
                Console.WriteLine($"--> Data already exists context:{nameof(db.StudentLessonSectors)}");
            }
            db.SaveChanges();
        }
    }
}
