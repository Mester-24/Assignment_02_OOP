using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Session02OOP.Inheritance;
using Session02OOP.PloyMorphismOverRiding;

namespace Session02OOP
{
    internal class Program
    {
        #region OverLoding
        public static int Sum(int X,int Y)
        {
            return X + Y;
        }
        public static int Sum(int X, int Y,int Z)
        {
            return X + Y +Z;
        }
        public static double Sum(double X,double Y)
        {
            return X + Y;
        }
        public static double Sum (double X,int Y)
        {
            return X + Y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Indexer
            PhoneBook Note = new PhoneBook(3);
            Note.AddPerson(0, "Mohammed", 123);
            Note.AddPerson(1,"Eshag",456);
            Note.AddPerson(2,"Abdalla",789);
            //Note.SetNumbes("Mohammed",999);//Setter Function
            // Console.WriteLine(Note.GetNumber("Mohammed"));//Getter Function
            //Numbers[0] = 50;
            // Note["Mohammed"] = 6868;//Using Indexer AS Setter
            //Console.WriteLine(Note["Mohammed"]);//Using Indexer AS Getter
            //string Name = "Mohammed";
            //  Console.WriteLine(Name[0]);//using Indexer For Get
            // Name[0] = 'M';//Indexser For String Can Not BE Used For Set just Get /Read Only
            #endregion
            #region Class
            Car C1;
            //Decalare Ffor Refernce From Type "car",Rerereing To Null
            //can Refer To An Object From Type Car or Object From Another Class
            //Inheriting From Car
            //CLR Will Allocate 4 Bytes For  The Refererce At Stac
            //CLR Will Allocate 0 Bytes At Heap
            //-------------------------------------------------------------------
            ////// C1=new Car(10);
            //new :
            //1- Allocate Required Bytes From The Object At Heap 16 Bytes
            //2- Intialize The Allocated Bytes Of The Object With Default Values Of It Is DataType
            //3- Call User Defined Constructor [IF Exists]
            //4- Assign The Address OF Allocated Object At Heap To Yhe Reference C1
            ///--------------------
            // /////Console.WriteLine(C1);

            #endregion
            #region Inheritance
            //Chiled chiled =new Chiled(1,2,3);
            //Console.WriteLine(chiled);

            #endregion
            #region Relationships Between Classes

            #endregion
            #region Access Modifiers(Private Ptoected - Protected- Internal Protected)

            #endregion
            #region Class VS Struct

            #endregion
            #region PloyMorphism
            #region Overloding
            // int Resualt = Sum(1,2);
            // int Resualt = Sum(1, 2,5);

            // Console.WriteLine($"The Resualt={Resualt}");
            #endregion
            #region OverRiding
            //TypeA typeA = new TypeA(3);
            //typeA.A = 5;
            //typeA.MyFun01();
            //typeA.MyFun02();
            TypeB typeB = new TypeB(5,6);
            typeB.A = 10;
            typeB.B = 20;
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion
            #endregion
        }
    }
}
