using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Association_Compostion
{
    internal class OrderItem
    {
        //1- Association Compostion RelationShip (Has A)
        //OrderItem HAs An Item
        public int Id {  get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity {  get; set; }
        public OrderItem(Product _product) { 
            Product = _product;
        }
    }
}
