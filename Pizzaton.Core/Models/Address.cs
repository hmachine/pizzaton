using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Core.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int Zip { get; set; }
    }
}