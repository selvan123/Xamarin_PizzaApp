using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_PizzaApp.Model
{
   public class Order
    {
        //Primary Key
        public Int64 OrderNumber { get; set; }
        public String OrderDate { get; set; }
       
       
        public Order()
        {

        }
    }
}
