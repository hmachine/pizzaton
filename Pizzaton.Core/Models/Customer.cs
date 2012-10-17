using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Models
{
    public class Customer : Person 
    {
        public Guid Id { get; set; }
        public Address Address { get; set; }
        public bool IsVip { get; set; }

        public Customer(string firstName, string lastName)
            : base(firstName, lastName)
        { }


    }
}