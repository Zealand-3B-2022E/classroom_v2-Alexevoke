using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {

        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            BirthMonth = birthmonth;
            BirthDay = birthday;
        }

        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int BirthDay { get; private set; }

        public string Season()
        {
            if (BirthMonth >= 3 && BirthMonth <= 5)
            {
                return "The student is born in spring";
            }
            else if (BirthMonth >= 6 && BirthMonth <= 8)
            {
                return "The student is born in summer";
            }
            else if (BirthMonth >= 9 && BirthMonth <= 11)
            {
                return "The student is born in autumn";
            }
            else
            {
                return "The student is born in winter";
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Birthmonth: {BirthMonth}, Birthday: {BirthDay}"; 
        }
    }
}
