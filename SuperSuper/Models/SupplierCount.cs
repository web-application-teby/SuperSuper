using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SuperSuper.Models
{
    [DataContract]
    public class SupplierCount
    {
        [DataMember(Name = "x")]
        public string Supplier { get; set; }

        [DataMember(Name = "y")]
        public int Count { get; set; }
    }
}
