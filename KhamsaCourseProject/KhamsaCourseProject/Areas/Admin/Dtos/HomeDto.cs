using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class HomeDto
    {
        public int Id { get; set; }
        public int StudentCount { get; set; }
        public string SectorName { get; set; }
    }
}
