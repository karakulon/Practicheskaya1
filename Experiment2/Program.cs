using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace experiment2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Эксперимент 2

            Student student1 = new Student {Name = "Artem", SurName = "Cursedov"};
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();
            Group group = new Group { Direction = "Engineer", Year = 2, Student = student1};
            student1.Group = group;
            student2.Group = group;
            student3.Group = group;
            student4.Group = group;
            student5.Group = group;
            Console.WriteLine(group.ToString());
            Console.WriteLine();
            // Эксперимент 3

            Console.WriteLine(student1.Group.ToString());
        }
    }
}
