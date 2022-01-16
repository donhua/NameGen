namespace NameGen
{
    class GenMix
    {
        /* из каждого массива берет по 1 рандомному элементу
        и составляет из них слово */
        public string RndPart(string[] name)
        {
            Random r = new Random();
            int i = r.Next(name.Length);
            return name[i];
        }
        public string Mix2(string[] a, string[] b)
        {
            return RndPart(a) + RndPart(b);
        }
    }

}