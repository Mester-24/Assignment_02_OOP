using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal class Car
    {
        #region Attributes
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        //If No User Defined Constructor Exitsts,Compiler Will Alwayes Geterate Empty Parametless Constructor
        //public Car()
        //{

        //}//Do Nothing

        //--------------------------------------------
        //Constructor Chainning
        #region Constructor
        public Car(int _Id,string _Model,double _Speed)
        {
            Console.WriteLine("Constructor 01");
            Id=_Id;
            Model = _Model;
            Speed = _Speed;
        }
        public Car(int _Id,string _Model):this(_Id,_Model,150)
        {
            Console.WriteLine("Constructor 02");
            //Id = _Id;
            //Model = _Model;
            //Speed = 150;

        }
        public Car(int _Id):this(_Id,"Mersides",250)
        {
            Console.WriteLine("Constructor 03");
           // Id = _Id;
        }
        #endregion
        #region Mehhod
        public override string ToString()
        {
            return $"Car Id={Id}\n Model Is ={Model}\n Spees Is={Speed}";
        }
        #endregion

    }

}
