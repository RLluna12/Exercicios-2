﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i = 0, num, negat = 0;
            double media = 0;

            while (i < 10)
            {
                Console.WriteLine("Digite um Numero: ");
                num = double.Parse(Console.ReadLine());
                i++;

                if (num < 0)
                {
                    negat = num + negat;
                    Console.WriteLine("Numero negativo Digitado" + num);
                    media = negat / i;


                }



            }
            Console.WriteLine("Soma dos numeros negativos: " + negat);
            Console.WriteLine("MEdia: " + media);
        }
    }
}
