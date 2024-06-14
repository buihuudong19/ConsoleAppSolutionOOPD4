using System;
namespace ConsoleAppOOPInheritanceAbstract
{
 
        public class Student
        {
            //Tinh truu tuong (abstractions)
            /*
             * Co gi?
                --> Thuộc tính/properties/attributes/data/fields

             */
            private int id;
            public int Id { get => id; set => id = value; }
            public string FullName { get; set; }
            public DateTime Dob { get; set; }
            public double Mark { get; set; }
            //Làm thế nào ta có thể "bypass" dữ liệu từ bên ngoài vào
            //constructor
            public Student()
            {
           
            }
            public Student(int id, string fullName, DateTime dob, double mark)
            {
                Id = id;
                FullName = fullName;
                Dob = dob;
                Mark = mark;
            }

            public override string ToString()
            {
                return $"Id: {this.id}, Full Name: {FullName}, Dob: {Dob} and Mark: {Mark}";
            }
    }
    
}
