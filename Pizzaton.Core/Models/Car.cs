using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}