using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
    [DataContract]
    public class Product
	{
        [DataMember(Name = "y")]
        public int Id { get; set; }

        [DataMember(Name = "label")]
        public string Name { get; set; }
        
		public double Price { get; set; }

		public bool Diet { get; set; }

		public string Supplier { get; set; }

        public bool Kosher { get; set; }

        public int Calories { get; set; }

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

        public ICollection<Purcheses> Purcheses { get; set; }
    }
    

}
