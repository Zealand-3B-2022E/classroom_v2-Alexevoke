// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

ClassRoom classroom1 = new ClassRoom("3B", new DateTime(2022, 9, 1));
Student student1 = new Student("Alexander", 8, 19);
Student student2 = new Student("Runi", 2, 24);
Student student3 = new Student("Anders", 1, 8);
Student student4 = new Student("Jonathan", 7, 16);
classroom1.ClassList.Add(student1);
classroom1.ClassList.Add(student2);
classroom1.ClassList.Add(student3);
classroom1.ClassList.Add(student4);

Console.WriteLine(classroom1.ToString());
foreach (Student student in classroom1.ClassList)
{
    Console.WriteLine(student.ToString());
    Console.WriteLine(student.Season());
}
Console.WriteLine();

classroom1.BirthdaysBySeason();


Console.WriteLine();
Console.WriteLine("Press any key to close this program...");
Console.ReadKey();