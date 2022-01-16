using System;
using System.Text;

namespace NameGen
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ForData Fd = new();
            Parse Pr = new();
            Pr.JsLoad(Fd);
            GenMix GM = new();
            Console.WriteLine(GM.Mix2(Fd.villagePart1, Fd.villagePart2));
            Console.WriteLine(GM.RndPart(Fd.villagePart1));
            Console.ReadLine();
        }
    }
}
