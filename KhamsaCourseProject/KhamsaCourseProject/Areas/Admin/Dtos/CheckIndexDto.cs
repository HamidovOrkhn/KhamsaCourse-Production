using KhamsaCourseProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class CheckIndexDto
    {
        public List<StudentPayment> Payments { get; set; }
        public List<Office> OfficePayments { get; set; }
        public List<Check> Checks { get; set; }
    }
}
