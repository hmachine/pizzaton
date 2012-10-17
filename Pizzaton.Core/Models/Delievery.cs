using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Models
{
    public class Delievery
    {
        public Guid Id { get; set; }
        public string Driver { get; set; }
        public Car Car { get; set; }
    }
}