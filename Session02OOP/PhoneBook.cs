using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02OOP
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numbers;
        int size;
        #endregion
        #region Properites
        public int Size//Read Only Property
        {
            get { return size; }
        }
        #endregion
        //Object Member Method
        #region Constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        #endregion
        #region Methods
        public void AddPerson(int Position, string Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                if (Position >= 0 && Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;
                }

            }

        }
        #endregion
        #region Encapsulation
        #region Getter/Setter

        //Getter
        public long GetNumber(string Name)
        {
            if(names !=null && numbers !=null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                        return numbers[i];
                }
            }
          
            return -1;
        }

        //Setter
        public void SetNumbes(string Name, long NewNumbers)
        {
            if(names !=null && numbers !=null)
            {
                for(int i=0;i<names.Length;i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = NewNumbers;
                    }
                }
            }

        }
        #endregion
        //Indxer
        //Is Special Property
        //1-Named Alwayes With Keyword this
        //2-Can Take Parmeters
        public long this[string Name]
        {
            get
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
                    }
                }

                return -1;
            }
            set
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            numbers[i] = value;
                        }
                    }
                }
            }
        }
        #endregion

    }
}
