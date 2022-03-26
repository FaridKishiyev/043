using System;
using System.Collections.Generic;
using System.Text;

namespace task043s.Models
{
    class Student
    {
        private static int _id;

        public int Id { get;}

        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }


        public Student(string name,string surname, int age,double point )
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Point = point;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nPoint: {Point}");
        }

        public static bool operator >(Student student1, Student student2)
        {
            return student1.Point > student2.Point;
        }

        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
    }

    
}
