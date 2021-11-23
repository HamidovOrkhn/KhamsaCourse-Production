using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Models
{
    public class StudentContract
    {
        public int Id { get; set; }
        public DateTime ContractDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double Value { get; set; }
        public double Debt { get; set; }
        public double Discount { get; set; }
        public int ContractTypeId { get; set; }
        public ContractType ContractType { get; set; }
    }
}
