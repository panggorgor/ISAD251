using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlymouthPub.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual List<Item> OrderItem { get; set; }
    }
}
