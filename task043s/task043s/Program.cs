using System;
using task043s.Models;

namespace task043s
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("ferid", "kisiyev", 19,85);
            Student student2 = new Student("kamal", "haciyev", 22,55);
            Student student3 = new Student("mehdi", "muradov", 25,68);
            Student student4 = new Student("ilkin", "hesenov", 23,44);

            

            Group grup1 = new Group();

            #region Studentləri əlavə edir.
            //grup1.AddStudent(student1);
            //grup1.AddStudent(student2);
            //grup1.AddStudent(student3);
            //grup1.AddStudent(student4);
            #endregion

            #region Bütün studentləri ekrana çıxardır.
            //Console.WriteLine(grup1.No);
            //foreach (var item in grup1.GetAllStudents())
            //{
            //    Console.WriteLine("------");

            //    item.ShowInfo();
            //}
            #endregion

            #region Sort olunmuş studentləri ekrana çıxardır
            //foreach (var item in grup1.Sort())
            //{
            //    Console.WriteLine("------");

            //    item.ShowInfo();
            //}
            #endregion
        }
    }
}
