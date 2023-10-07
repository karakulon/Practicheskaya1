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
            Console.WriteLine("\n____________________________________\nExperiment: 2\n____________________________________\n");

            Group group = new Group { Direction = "Software engineer", Year = 2};
            group.Add(new Student { Name = "Man", SurName = "Maanov" });
            group.Add(new Student());
            group.Add(new Student());
            group.Add(new Student());
            group.Add(new Student());
            Console.WriteLine(group.ToString());
            Console.WriteLine();

            // Эксперимент 3
            Console.WriteLine("\n____________________________________\nExperiment: 3\n____________________________________\n");

            Group group2 = new Group { Direction = "Software developer", Year = 3};
            Student student1 = new Student { Name = "Chel", SurName = "Chelov" };
            Student student2 = new Student();
            Student student3 = new Student();
            group2.Add(student1);
            group2.Add(student2);
            group2.Add(student3);
            Console.WriteLine(group2.ToString());
            Console.WriteLine();
            Console.WriteLine(student1.Group.ToString());

            // Эксперимент 4
            Console.WriteLine("\n____________________________________\nExperiment: 4\n____________________________________\n");

            Group group3 = new Group { Direction = "Cyber security", Year = 4 };
            Student student41 = new Student { Name = "Cyber", SurName = "Securov" };
            Student student42 = new Student();
            Student student43 = new Student();
            group3.Add(student41);
            group3.Add(student42);
            group3.Add(student43);
            Console.WriteLine(group3.ToString());

            // Эксперимент 5
            Console.WriteLine("\n____________________________________\nExperiment: 5\n____________________________________\n");

            Group group4 = new Group { Direction = "Design", Year = 5 };
            group4.New("Design", "Designov");
            group4.New("Tipok", "Ivanov");
            group4.New("Vitek", "Advansov");
            Console.WriteLine(group4.ToString());

            // Эксперимент 6
            Console.WriteLine("\n____________________________________\nExperiment: 6/1\n____________________________________\n");

            Group group5 = new Group { Direction = "Project Managment", Year = 6 };
            foreach (var s in new Student[]
            {
                new Student { Name = "Robert", SurName = "Bobert"},
                new Student { Name = "Victor", SurName = "Rootcrop"},
                new Student { Name = "Mister", SurName = "Twister" }
            })
            {
                group5.Add(s);
            }
            Group clone = group5.Clone();
            Console.WriteLine(clone.ToString());

            ////////////////
            Console.WriteLine("\n____________________________________\nExperiment: 6/2\n____________________________________\n");

            Group group6 = new Group { Direction = "DevOps", Year = 7 };
            group6.New("Dev", "Opsov");
            group6.New("Tipok", "Ivanov");
            group6.New("Vitek", "Advansov");
            Console.WriteLine(group6.ToString());




        }
    }
}
