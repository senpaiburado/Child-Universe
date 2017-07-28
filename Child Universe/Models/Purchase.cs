using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Child_Universe.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public User Purchaser { get; set; }
        public string Adress { get; set; }
        public Toy Toy { get; set; }
        public DateTime Time { get; set; }
    }
}