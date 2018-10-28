using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
    public class PurchesesView
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int ProductId { get; set; }

        public string CustomerName { get; set; }

        public int CustomerId { get; set; }

        public DateTime PurchesDate { get; set; }

        public bool Purchesed { get; set; }
    }
}

