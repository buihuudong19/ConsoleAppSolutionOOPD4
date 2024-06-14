using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPInheritanceAbstract
{
   public class StudentManagerment
   {
        //co gi?
        private List<Student> students;

        public List<Student> Students { get => students; set => students = value; }

        //constructor
        public StudentManagerment()
        {
            this.Students = new List<Student>();
        }

        public StudentManagerment(List<Student> students)
        {
            this.Students = students;
        }
        //Them moi 1 SV vao 
        public void AddStudent(Student s)
        {
            if(s is not null)
            {
                this.Students.Add(s);
            }
        }
        //Lay ra 1 sinh vien theo ma
        public Student GetStudentById(int id)
        {
            //cach 1
            for(int i=0; i <Students.Count; i++)
            {
                if(Students[i].Id == id)
                {
                    return Students[i];
                }
            }
            //cach 2
           // return students.FirstOrDefault(s => s.Id == id);


            //trong truong hop khong tim thay
            return null;

        }
        //return all students

        public List<Student> GetALlStudent()
        {
            return Students;
        }





       

    }
}
