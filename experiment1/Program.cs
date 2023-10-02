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

            // созданы экземпляры классов
            A example = new A {PropertyA = "Ассоциация A"};
            B example2 = new B {PropertyB = "Ассоциация B"};
            // установлена ассоциация
            example.GetB = example2;
            // обратились к свойству B через A
            Console.WriteLine(example.GetB.PropertyB);

            Console.WriteLine();
            // Эксперимент 1.2

            // создаём экземпляры классов
            A example2_1 = new A { PropertyA = "Двунаправленная ассоциация A" };
            B example2_2 = new B { PropertyB = "Двунаправленная ассоциация B" };
            // устанавливаем ассоциацию
            example2_1.GetB = example2_2;

            Console.WriteLine($"{example2_1.GetB.PropertyB}\n{example2_2.GetA.PropertyA}");

            Console.WriteLine();
            // Эксперимент 1.3

            // создать экземпляры классов
            A2 example4 = new A2();
            B2 example3 = new B2 {PropertyB2 = "Агрегация B" };
            // добавить ссылку в корень агрегата
            example4.AddB2(example3);
            // обратиться из A к B
            Console.WriteLine(example4.B2.PropertyB2);

            Console.WriteLine();
            // Эсперимент 1.4

            // создать экземпляр класса 
            // B создаётся в конструкторе A
            A3 example6 = new A3();
            // обращение к B в A
            example6.B3.PropertyB3 = "Композиция B";
            Console.WriteLine(example6.B3.PropertyB3);

        }
    }
}
