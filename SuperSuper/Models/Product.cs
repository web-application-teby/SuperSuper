using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; }

        
		public double Price { get; set; }

		public bool Diet { get; set; }

		public string Supplier { get; set; }

        public bool Kosher { get; set; }

        public Category category { get; set; }

        public enum Category
        {
            All,
            Dairy,
            Vegetables,
            Fruits,
            Drinks,
            Toiltries,
            Snacks,
            Frozen,
            Cupboard
        }
    }
    

}
