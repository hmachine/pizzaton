using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzaton.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public float Price { get; set; }
        public Delievery Delievery { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}