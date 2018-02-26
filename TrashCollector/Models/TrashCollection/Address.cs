using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace TrashCollector.Models.TrashCollection
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; } 
        [MaxLength(2)]
        public string State { get; set; }
        public int ZipCode { get; set; }
        [ScriptIgnore]
        public int CustomerId { get; set; }
        [ScriptIgnore]
        public Customer Customer { get; set; }

    }
}