using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Child_Universe.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        public List<Purchase> Purchases { get; set; }
        public int MoneySpent { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}