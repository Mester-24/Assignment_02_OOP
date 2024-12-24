using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.Inheritance
{
    internal class Chiled : Parent
    {
        public int Z { get; set; }
        public Chiled(int _X,int _Y,int _Z):base(_X,_Y)//Constrouctor Chainning
        {
            Z = _Z;
        }
    }
}
