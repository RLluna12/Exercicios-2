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
           
            int[] v = new int[6];
            for(int i=0; i<6; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Inverso do q foi digitado: ");
            for (int i = 5; i >= 0; i--)
            {
                
                Console.WriteLine(v[i]);
            }
        }
    }
}
