using KhamsaCourseProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class CheckDto
    {
        public Student Student { get; set; }
        public StudentContract Contract { get; set; }
        public StudentPayment Payment { get; set; }
        public Sector Sector { get; set; }

    }
}
