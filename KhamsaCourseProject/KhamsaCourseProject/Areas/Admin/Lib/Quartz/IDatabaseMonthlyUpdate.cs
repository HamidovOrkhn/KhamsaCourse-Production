using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Lib.Quartz
{
    interface IDatabaseMonthlyUpdate
    {
        Task UpdateDatabase();
        Task UpdateEmployee();
    }
}
