using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingBackendDemo.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public long NationalityId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
