using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 4;
            double cand1 = 0, cand2 = 0, branco = 0, nulo = 0, total;

            while (opcao != -1)
            {
                opcao++;
                Console.WriteLine("1 candidato A");
                Console.WriteLine("2 candidato B");
                Console.WriteLine("3 Voto em branco");
                Console.WriteLine("4 voto nulo");
                Console.WriteLine("\nDigite seu voto:");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Candidato A, Obrigado!!\n");
                        cand1++;
                        break;
                    case 2:
                        Console.WriteLine("Candidato B, Obrigado!!\n");
                        cand2++;
                        break;
                    case 3:
                        Console.WriteLine("Voto em branco, Obrigado!!\n");
                        branco++;
                        break;
                    case 4:
                        Console.WriteLine("Voto nulo, Obrigado!!\n");
                        nulo++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, escolha novamente!!");
                        break;

                }


            }
            Console.WriteLine("Total de votos do candidato A: " + cand1);
            Console.WriteLine("Total de votos do candidato B: " + cand2);
            Console.WriteLine("Total de votos em branco: " + branco);
            Console.WriteLine("Total de votos nulo: " + nulo);
            total = cand1 + cand2 + branco + nulo;
            Console.WriteLine("Total de votos lido :" + total);
            if (cand1 > cand2)
            {
                Console.WriteLine("Candidato A Vencedor!! {0} de Votos.",cand1);
            }
            else
            {
                Console.WriteLine("Candidato B Vencedor!!Total de: {0} Votos.",cand2);
            }
        }
    }
}
