using System;
using System.Text;

namespace NameGen
{
    class GenMix
    {
        string[] a;
        string[] b;
        Random r = new Random();
        public GenMix(string[] a, string[] b)
        {
            this.a = a;
            this.b = b;
        }
        private string RndPart(string[] name)
        {
            int i = r.Next(name.Length);
            return name[i];
        }
        public string Mix()
        {
            
            return RndPart(a) + RndPart(b);
        }

    }
    class Gen
    {
        string[] a;
        public Gen(string[] a) => A = a;

        public string[] A { get => a; set => a = value; }

        public string Rnd()
        {
            Random r = new();
            int i = r.Next(A.Length);
            return A[i];
        }
    }

    class Programm
    {
        public static void Main(string[] args)
        {
            string[] a = { "Сокол", "Горох", "Дурак", "Пердак", "Чмок", "Кузюк", 
                "Ягод", "Блох", "Тесак", "Глаз", "Катях", "Моск", "Чмен", "Пук",
                "Человек", "Костыл", "Кладбищ", "Болот", "Пар", "Сыр", "Бор", "Горк" };
            string[] b = { "ово", "инское", "овка", "ино", "инка", "овское", "инский" }; //Окончания названия деревень, сел поселков и хуторов
            string[] c = { "енко", "ин", "евский", "ов" }; //окончания фамилий
            string[] d = { "Василий ", "Фёдор ", "Павел ", "Вениамин ", "Арсений " };
            var Village = new GenMix(a, b);
            var Soname = new GenMix(a, c);
            var Name = new Gen(d);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("В посёлке " + Village.Mix() + " был ранен " + Name.Rnd() + " " + Soname.Mix());
            }
            Console.ReadLine();
        }
    }

}