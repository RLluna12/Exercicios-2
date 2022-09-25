using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao=0;
            double cheque, cartao, cedula, resul1=0, resul2 = 0, resul3 = 0, total;

            while (opcao != -1)
            {
                opcao++;
                Console.WriteLine("1 CHEQUE");
                Console.WriteLine("2 CARTAO");
                Console.WriteLine("3 CEDULA");
                Console.WriteLine("\nDigite sua opção:");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cheque");
                        Console.WriteLine("Digite o valor: ");
                        cheque = double.Parse(Console.ReadLine());
                        resul1 = cheque+resul1;
                        break;
                    case 2:
                        Console.WriteLine("Cartao");
                        Console.WriteLine("Digite o valor: ");
                        cartao = double.Parse(Console.ReadLine());
                        resul2 = cartao+resul2;
                        break;
                    case 3:
                        Console.WriteLine("Cedula");
                        Console.WriteLine("Digite o valor: ");
                        cedula = double.Parse(Console.ReadLine());
                        resul3 = cedula+resul3;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha novamente!!");
                        break;
                       
                }
               
               
            }
            Console.WriteLine("Total gasto em cheques: "+resul1);
            Console.WriteLine("Total gasto em cartao de Credito: "+resul2);
            Console.WriteLine("Total gasto em Cedulas: "+resul3);
            total = resul1 + resul2 + resul3;
            Console.WriteLine("Total :"+ total);
        }
    }
}
