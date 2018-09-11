using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestApplication.Models
{
    public class BillDetailsModel
    {
        public IEnumerable<CustomerDetailsModel> ProductList { get; set; }
        public int TotalBill { get; set; }
        
        public int TotalDiscount { get; set; }
    }
}
