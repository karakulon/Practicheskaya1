using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace experiment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Эксперимент 1.1

            A example = new A {PropertyA = "Ассоциация"};
            B example2 = new B {PropertyB = "Ассоциация"};
            example.GetB = example2;
            Console.WriteLine(example.GetB.PropertyB);

            // Эксперимент 1.2

            example2.GetA = example;
            Console.WriteLine($"{example.GetB.PropertyB}\n{example2.GetA.PropertyA}");

            // Эксперимент 1.3

            B2 example3 = new B2 {PropertyB2 = "Агрегация" };
            A2 example4 = new A2();
            example4.AddB2(example3);
            Console.WriteLine(example4.B2.PropertyB2);

            // Эсперимент 1.4

            A3 example6 = new A3();
            example6.B3.PropertyB3 = "Композиция";
            Console.WriteLine(example6.B3.PropertyB3);

        }
    }
}
