using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "Hello, World!"

            string helloW = "Hello World!";

            int counterh = 0;
            int countero = 0;
            int counterl = 0;

            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    counterh++;
                }
                if(helloW[i] == 'o')
                {
                    countero++;
                }
                if(helloW[i] == 'l')
                {
                    counterl++;
                }
            }

        }
    }
}
