using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
    public class CustomerBasket
    {
        [Key]
        public string ProductName { get; set; }

        public int ProductsCount { get; set; }
    }
}
