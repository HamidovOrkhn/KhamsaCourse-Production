using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class StatisticsSelectDto
    {
        public int SectorId { get; set; }
        public string Name { get; set; }
        public double Benefit { get; set; }
        public double Cost { get; set; }
        public string CategoryName { get; set; }
    }
}
