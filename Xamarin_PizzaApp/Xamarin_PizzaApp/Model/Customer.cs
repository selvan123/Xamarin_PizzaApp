using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_PizzaApp.Model
{
    public class Customer
    {
        //Primary Key
        public Int32 PhoneNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Char MiddleInit { get; set; }
        public String EmailAddress { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public Int16 Zipcode { get; set; }

        public Customer()
        {
          
        }
    }
}
