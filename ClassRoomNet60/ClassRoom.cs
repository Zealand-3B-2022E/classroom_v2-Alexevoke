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

        public ClassRoom(string className, DateTime semesterStart)
        {
            ClassName = className;
            ClassList = new List<Student>();
            SemesterStart = semesterStart;
        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public void BirthdaysBySeason()
        {
            var seasons =
                from student in ClassList
                group student by student.Season() into bdaySeason
                select new
                {
                    Season = bdaySeason.Key,
                    Count = bdaySeason.Count(),
                };

            foreach (var season in seasons)
            {
                Console.WriteLine(season.Season);
                Console.WriteLine(season.Count);
            }
        }

        public override string ToString()
        {
            return $"Classname: {ClassName}, Semester start: {SemesterStart.Day}/{SemesterStart.Month}/{SemesterStart.Year}";
        }

    }
}
