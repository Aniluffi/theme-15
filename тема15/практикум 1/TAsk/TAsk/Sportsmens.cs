using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk
{
    class Sportsmens : Studens
    {
        short height;
        short weight;
        static int count;

       public Sportsmens(string name, string surname, string patronymic, short height, short weight) 
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.height = height;
            this.weight = weight;
        }

        public static void PrintAllArray(Sportsmens[] a)
        {
            foreach (Sportsmens el in a)
            {
                if (el.weight > 70)
                {
                    Console.WriteLine($"Данные студента\n" +
                    $"Имя: {el.name}\n" +
                    $"Фамилия: {el.surname}\n" +
                    $"Отчество: {el.patronymic}\n" +
                    $"Вес: {el.weight}\n" +
                    $"Рост: {el.height}\n");
                    count++;
                }
            }

            Console.WriteLine($"Всего человек больше 70 кг - {count}\n");
        }
        public static Sportsmens[] nCreationSportsmens(byte n)
        {
            Sportsmens[] st = new Sportsmens[n];
            for (int i = 0; i < st.Length; i++)
            {
                Console.Write("Введите имя:");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Ведите фамилию:");
                string surname = Convert.ToString(Console.ReadLine());

                Console.Write("Введите Отчество:");
                string patronymic = Convert.ToString(Console.ReadLine());

                Console.Write("Введите вес: ");
                short weight = short.Parse(Console.ReadLine());

                Console.Write("Введите рост: ");
                short height = short.Parse(Console.ReadLine());
                Console.WriteLine();

                st[i] = new Sportsmens(name, surname, patronymic, weight, height);
            }
            return st;
        }
    }
}
