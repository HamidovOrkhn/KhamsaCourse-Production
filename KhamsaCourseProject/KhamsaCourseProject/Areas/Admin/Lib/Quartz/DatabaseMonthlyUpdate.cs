using KhamsaCourseProject.Areas.Admin.Data;
using KhamsaCourseProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Lib.Quartz
{
    public class DatabaseMonthlyUpdate : IDatabaseMonthlyUpdate
    {
        private readonly AdminContext _context;
        public DatabaseMonthlyUpdate(AdminContext context)
        {
            _context = context;
        }
        public async Task UpdateDatabase()
        {
            var datenow = DateTime.Now;

            List<StudentContract> contracts = (from student in _context.Students.Where(a => a.IsActive == 1)
                                               join contract in _context.Contracts on student.Id equals contract.StudentId
                                               where datenow >= contract.ContractDate.AddMonths(1) && contract.ContractDate.AddMonths(1) <= datenow
                                               select new StudentContract
                                               {
                                                   ContractDate = contract.ContractDate,
                                                   ContractType = contract.ContractType,
                                                   ContractTypeId = contract.ContractTypeId,
                                                   Debt = contract.Debt,
                                                   Discount = contract.Discount,
                                                   Id = contract.Id,
                                                   StudentId = contract.StudentId,
                                                   Value = contract.Value
                                               }).ToList();
            if (contracts.Count > 0)
            {
                for (int i = 0; i < contracts.Count; i++)
                {
                    var cntr = _context.Contracts.Where(a => a.Id == contracts[i].Id).FirstOrDefault();
                    cntr.Debt = cntr.Debt + cntr.Value;
                    cntr.ContractDate = cntr.ContractDate.AddMonths(1);
                    _context.SaveChanges();
                }
            }
          

        }
    }
}
