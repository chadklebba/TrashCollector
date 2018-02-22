using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models.TrashCollection
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public List<Address> Addresses { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        [Display(Name = "Garbage Pickup Date")]
        public string PickupDate { get; set; }
        //public string RoleId { get; set; }
        //[ForeignKey("RoleId")]
        //public virtual Role { get; set; }
        [Display(Name = "Vacation Start Date")]
        public string VacationStartDate { get; set; }
        [Display(Name = "Vacation End Date")]
        public string VacationEndDate { get; set; }
        
    }
}