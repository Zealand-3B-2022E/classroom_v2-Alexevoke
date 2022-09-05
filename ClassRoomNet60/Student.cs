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
    }
}
