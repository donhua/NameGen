namespace NameGen
{
    class GenMix
    {
        /* из каждого массива берет по 1 рандомному элементу
        и составляет из них слово */

        private string[] a;
        private string[] b;
        public GenMix(string[] a, string[] b)
        {
            this.a = a;
            this.b = b;
        }
        private string RndPart(string[] name)
        {
            Random r = new Random();
            int i = r.Next(name.Length);
            return name[i];
        }
        public string Mix()
        {
            return RndPart(a) + RndPart(b);
        }

    }

}