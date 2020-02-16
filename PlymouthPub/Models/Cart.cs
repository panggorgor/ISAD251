using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlymouthPub.Models
{
    public class Cart
    {



        public int Id { get; set; }
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Item product { get; set; }
    }
}