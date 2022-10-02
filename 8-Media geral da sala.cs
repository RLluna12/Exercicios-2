using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[15];
            int media = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Nota: ");
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] > 10)
                {
                    Console.WriteLine("erro");
                    v[i] = v[15];
                }
               
                media += v[i];
            }
            Console.WriteLine("Media geral: " + media / 15);
        }
    }
}
