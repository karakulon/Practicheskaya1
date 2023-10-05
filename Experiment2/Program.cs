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

            Group group = new Group { Direction = "Software engineer", Year = 2};
            group.Students.Add(new Student());
            group.Students.Add(new Student());
            group.Students.Add(new Student());
            group.Students.Add(new Student());
            group.Students.Add(new Student());
            Console.WriteLine(group.ToString());
            Console.WriteLine();

            // Эксперимент 3

            Group group2 = new Group { Direction = "Software developer", Year = 3};
            Student student1 = new Student { Group = group2 };
            Student student2 = new Student { Group = group2 };
            Student student3 = new Student { Group = group2 };
            group2.Students.Add(student1);
            group2.Students.Add(student2);
            group2.Students.Add(student3);
            Console.WriteLine(group2.ToString());
            Console.WriteLine();
            Console.WriteLine(student1.Group.ToString());
        }
    }
}
