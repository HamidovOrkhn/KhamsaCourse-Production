using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhamsaCourseProject.Areas.Admin.Dtos
{
    public class PaymentModalDto
    {
        public string PaymentDate { get; set; }
        public double Value { get; set; }
        public double ContractValue { get; set; }
        #nullable enable
        public long? Id { get; set; }
        public string Desc { get; set; }
    }
}
