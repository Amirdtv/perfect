using System;

namespace ConsoleApp12
{
    class Perfetc
    {
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                if (value > 0)
                {
                    x = value;
                }
            }
        }

        public Perfetc() { }
        public Perfetc(int input)
        {
            x = input;
        }
        public void calc()
        {
            int c = 0;
            for(int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    c = c + i;
                }
            }
            if (c == x)
            {
                Console.WriteLine(" perfect number ");
            }
            else
            {
                Console.WriteLine(" not perfect ");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Perfetc p = new Perfetc(input);
            p.calc();
            Console.ReadKey();
        }
    }
}