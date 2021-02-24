using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ePhoneMarket.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Model = "Huawei P20", Price = 40000, Manufacturer = "Huawei"});
            context.Phones.Add(new Phone() { Model = "Samsung S9", Price = 58000, Manufacturer = "Samsung" });
            context.Phones.Add(new Phone() { Model = "LG G6", Price = 37000, Manufacturer = "LG" });

            base.Seed(context);
        }
    }
}