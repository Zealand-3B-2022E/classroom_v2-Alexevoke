using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private int _birthmonth;

        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            BirthMonth = birthmonth;
            BirthDay = birthday;
        }

        public string Name { get; private set; }
        public int BirthMonth {
            get { return _birthmonth; }
            private set {
                if (value >= 1 && value <= 12)
                {
                    _birthmonth = value;
                }
            }
        }
        public int BirthDay { get; private set; }

        public string Season()
        {
            if (BirthMonth >= 3 && BirthMonth <= 5)
            {
                return "Spring";
            }
            else if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "Summer";
            }
            else if (BirthMonth >= 9 && BirthMonth <= 11)
            {
                return "Autumn";
            }
            else
            {
                return "Winter";
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Birthmonth: {BirthMonth}, Birthday: {BirthDay}"; 
        }
    }
}
