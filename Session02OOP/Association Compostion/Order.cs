using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Association_Compostion
{
    internal class Order
    {
        //1- Asscciation Compostion(Has A)
        //Order Has A Item
        public int Id {  get; set; }
        public string BuyerEmail {  get; set; }
        public decimal SubTotal {  get; set; }
        public OrderItem[] Items { get; set; }
        public Order(string _BuyerEmail, OrderItem[] _Item)
        {
            BuyerEmail = _BuyerEmail;
            Items = _Item;
        }

    }
}
