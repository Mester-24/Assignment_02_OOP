using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP.PloyMorphismOverRiding
{
    internal class TypeB :TypeA
    {
        public int B {  get; set; }
        public TypeB(int _A,int _B):base(_A)
        {
            B = _B; 
        }
        public new void MyFun01()
        {
            Console.WriteLine("Iam Chiled[Derived]");
        }
        public override void MyFun02()
        {
            Console.WriteLine( $"Type B is A={A} , B={B}");
        }
    }
}
