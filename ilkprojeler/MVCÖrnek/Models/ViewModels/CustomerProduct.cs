using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCÖrnek.Models.ViewModels
{
    public class CustomerProduct
    {
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
