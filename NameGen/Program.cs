using System;
using System.Text;

namespace NameGen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] a = {"Sed", "Gart", "Akin" };
            string[] b = {"aze", "ecr", "yrd" };   
            GenMix GM = new();
            Console.WriteLine(GM.Mix2(a, b));
            Console.WriteLine(GM.RndPart(a));
            Console.ReadLine();
        }
    }
}
