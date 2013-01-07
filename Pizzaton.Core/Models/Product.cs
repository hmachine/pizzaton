using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}