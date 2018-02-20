using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashCollector.Models;
using TrashCollector.Models.TrashCollection;

namespace TrashCollector.Data
{
    public class DummyData
    {
        public static List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    FirstName="Chad",
                    LastName="Klebba",
                    PhoneNumber="414-588-7535",
                    EmailAddress="chad.klebba@gmail.com",
                },
                new Customer()
                {
                    FirstName="Christine",
                    LastName="Granzow",
                    PhoneNumber="414-555-0123",
                    EmailAddress="christine.granzow@gmail.com",
                },
                new Customer()
                {
                    FirstName="Brad",
                    LastName="Klebba",
                    PhoneNumber="414-588-5373",
                    EmailAddress="brad.klebba@gmail.com",
                },
            };
            return customers;
        }
        public static List<Address> getAddresses(ApplicationDbContext context)
        {
            List<Address> addresses = new List<Address>()
            {
                new Address()
                {
                   Street="N63 W23347 Main St. Apt. 102D",
                   City="Sussex",
                   State="WI",
                   ZipCode=53089,
                   CustomerId = 1,
                },
                 new Address()
                {
                   Street="1022 S 121st St.",
                   City="West Allis",
                   State="WI",
                   ZipCode=53214,
                   CustomerId = 2,
                },
                  new Address()
                {
                   Street="1124 Glacier Pass",
                   City="Slinger",
                   State="WI",
                   ZipCode=53086,
                   CustomerId = 3,
                },

            };
            return addresses;
        }
    }
}