using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ePhoneMarket.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PhoneId { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}