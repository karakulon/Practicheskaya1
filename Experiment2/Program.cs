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
            group.Add(new Student());
            group.Add(new Student());
            group.Add(new Student());
            group.Add(new Student());
            group.Add(new Student());
            Console.WriteLine(group.ToString());
            Console.WriteLine();

            // Эксперимент 3

            Group group2 = new Group { Direction = "Software developer", Year = 3};
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            group2.Add(student1);
            group2.Add(student2);
            group2.Add(student3);
            Console.WriteLine(group2.ToString());
            Console.WriteLine();
            Console.WriteLine(student1.Group.ToString());

            // Эксперимент 4

            Group group3 = new Group { Direction = "Software developer", Year = 3 };
            Student student11 = new Student();
            Student student22 = new Student();
            Student student33 = new Student();
            group2.Add(student1);
            group2.Add(student2);
            group2.Add(student3);
            Console.WriteLine(group3.ToString());
        }
    }
}
