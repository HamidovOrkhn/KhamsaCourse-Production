using KhamsaCourseProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class CheckOfficeDto
    {
        public Office Payment { get; set; }
        public Sector Sector { get; set; }
    }
}
