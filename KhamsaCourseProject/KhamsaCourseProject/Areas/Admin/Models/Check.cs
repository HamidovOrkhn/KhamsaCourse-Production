using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Models
{
    public class Check
    {
        public long Id { get; set; }
        public long PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CategoryId { get; set; }
        public PaymentCategory Category { get; set; }
        public DateTime CheckDate { get; set; }
    }
}
