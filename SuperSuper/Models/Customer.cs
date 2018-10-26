using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
	public class Customer
	{
        //[Required]
        public int Id { get; set; }

        //[Required]
        public string UserName { get; set; }

        //[Required]
        public string Address { get; set; }

        public string EmailAdress { get; set; }

        //[Required(ErrorMessage = "please provide password")]
        //[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        //public List<Product> CustomerBucket{ get; set; }
    }
}
