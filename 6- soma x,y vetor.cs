using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] v = new int[10];
            Console.WriteLine("Digite o valor de x");
            v[8] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y");
            v[9] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("numeros do vetor");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("soma de x: ");
            for (int i = 0; i <8; i++)
            {

                Console.WriteLine(v[i] + v[8]);
            }
            Console.WriteLine("soma de y: ");
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine(v[i] + v[9]);
            }
        }
    }
}
