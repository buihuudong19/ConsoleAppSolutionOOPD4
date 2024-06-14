using System;

namespace ConsoleAppOOPInheritanceAbstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo đối tượng
            Student s1 = new Student();
            s1.Id = 1;
            s1.FullName = "Dongbh";
            s1.Dob = new DateTime(1982, 08, 25);
            s1.Mark = 8.5d;

            Student s2 = new Student(2, "Ma van meo", new DateTime(2000, 02, 19), 9.5);
            Console.WriteLine(s2.FullName);

        }
    }
}
