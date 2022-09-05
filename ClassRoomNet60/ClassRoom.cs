using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {


        public ClassRoom()
        {
            ClassName = "dummy";
            ClassList = new List<Student>();
            SemesterStart = new DateTime(2022, 9, 1);

        }


        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

    }
}
