using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace manymany.Models
{
    public class CustomerSupplier
    {
        public int customerId { get; set; }
        public Customer customer { get; set; }

        public int suplierId { get; set; }
        public Supplier suplier { get; set; }
    }
}
