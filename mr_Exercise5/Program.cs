using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int RIJ = 25;
            const int KOLOM = 35;
            char charChars;

            Console.WriteLine();

            Random randNummer = new Random();
            char[,] charArray = new char[RIJ, KOLOM];


            for (int a = 0; a < 50; a++)
            {
                for (int i = 0; i < RIJ; i++)
                {
                    for (int j = 0; j < KOLOM; j++)
                    {
                        charChars = Convert.ToChar(randNummer.Next(126, 255));
                        charArray[i, j] = charChars;
                        Console.Write(charArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(200);
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
