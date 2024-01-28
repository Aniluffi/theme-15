using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk
{
    class Studens
    {
        protected string name;//чтобы без пробелов,при ошибке в поле ничего не идет
        protected string surname;//чтобы без пробеловб при ошибке в поле ничего не идет
        protected string patronymic;//чтобы без пробелов при ошибке в поле ничего не идет

        /// <summary>
        /// поле которое принимает булево значение,где тру мужской и фолс женский
        /// </summary>
        string gender;//ничего нельзя вписать кроме гендера
        ushort yearBirth;//нельзя вписать отриц число и детей меньше 5 лет 

        public string Name 
        { 
            get => name; 
            set
            {
                name = CheckingSpace(value, "уберите пробелы в имени");
            }
        }
        public string Surname 
        { 
            get => surname;
            set => surname = CheckingSpace(value, "уберите пробелы в фамилии"); 
        }
        public string Patronymic 
        { 
            get => patronymic; 
            set => patronymic = CheckingSpace(value, "уберите пробелы в отчестве"); 
        }
        public string Gender 
        { 
            get => gender; 
            set
            {
                if (value == "true") gender = "мужской";
                else if (value == "folse") gender = "женский";
                else if (value != "true" & value != "folse") Console.WriteLine("Введите пол конкретнее");
            }
        }
        public ushort YearBirth 
        { 
            get => yearBirth;
            set
            {
                if (2019 < value & value <= 2024)
                {
                    Console.WriteLine("Ошибка: Маленький возраст");
                    yearBirth = 0;
                } else if (2019 > value)
                {
                    yearBirth = value;
                }
            } 
        }

        
        public Studens()
        {

        }

        public Studens(string name, string surname, string patronymic, string gender, ushort yearBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Gender = gender;
            this.YearBirth = yearBirth;
        }

        /// <summary>
        ///  метод который проверяет правильность записи ФИО
        /// </summary>
        /// <param name="word">параметр который принимает слово</param>
        /// <param name="misstake">параметр принимает значение которое пказывает из за чего ошибка</param>
        /// <returns>возращает ошибку при ее наличие</returns>
        private string CheckingSpace(string word,string misstake)
        {
            char[] ChekWord = word.ToCharArray();
            foreach (char el in ChekWord)
            {
                if (el == Convert.ToChar(" "))
                {
                    Console.WriteLine($"ошибка: " + misstake);
                    return "";
                }
               
            }
            return word;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">колличество создаваемых студентов</param>
        public static Studens[] nCreationStudents(byte n)
        {
            Studens[] st = new Studens[n];
            for (int i = 0;i < st.Length;i++)
            {
                Console.Write("Введите имя:");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Ведите фамилию:");
                string surname = Convert.ToString(Console.ReadLine());

                Console.Write("Введите Отчество:");
                string patronymic = Convert.ToString(Console.ReadLine());

                Console.Write("Введите пол(мужской - true/женский - folse)");
                string gender = Convert.ToString(Console.ReadLine());

                Console.Write("Год рождения(не менее 5 лет):");
                ushort yearBirth = ushort.Parse(Console.ReadLine());
                Console.WriteLine();

                st[i] = new Studens(name, surname, patronymic, gender, yearBirth);
            }
            return  st;
        }
        /// <summary>
        /// метод для вывода всех студентов из массива
        /// </summary>
        /// <param name="a">массив со всеми студентами</param>
        public static void PrintAllArray(Studens[] a)
        {
            foreach (Studens el in a)
            {
                Console.WriteLine($"Данные студента\n" +
                    $"Имя: {el.name}\n" +
                    $"Фамилия: {el.surname}\n" +
                    $"Отчество: {el.patronymic}\n" +
                    $"Пол: {el.gender}\n" +
                    $"Год рождения: {el.yearBirth}\n");
            }
        }
    }
}
