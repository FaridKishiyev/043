using System;
using System.Collections.Generic;
using System.Text;

namespace task043s.Models
{
    class Group
    {
        private static int _noNumber = 100;
        private string _No;
        public string No { get; }

        private Student[] students;


        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }

        public Student[] Sort()
        {
            Student[] stu = new Student[students.Length];
            Array.Copy(students,stu, students.Length );
            for (int i = 0; i < stu.Length-1; i++)
            {
                for (int j = 0; j < stu.Length - i - 1; j++) 
                {

                    if (stu[j].Point > stu[j + 1].Point)
                    {
                        double temp = stu[j].Point;
                        stu[j].Point = stu[j + 1].Point;
                        stu[j + 1].Point = temp;
                    }

                }
            
            }

            return stu;
        }
        public Group()
        {
            _noNumber++;

            No = "AP" + _noNumber;
            students = new Student[0];
        }
    }
}
