using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int masculino=0, idadem = 0, idadef = 0, sexo=0, i=-1, id=0, feminino = 0, mediaidd = 0, idade = 0, media = 0, idademediaf = 0, idademediam = 0;
            double  id1, alturaf=0, alturam=0, malturaf=0, malturam=0;

            while(sexo!=-1 && sexo<=1000)
            {
                
                Console.WriteLine("Digite seu sexo\n0-FEMININO:\n1-MASCULINO:");
                sexo = int.Parse(Console.ReadLine());
                
                switch (sexo)
                {
                    
                    case 0:
                        Console.WriteLine("Digite sua Idade: ");
                        idadef = int.Parse(Console.ReadLine());
                        if(idadef >= 18 && idadef <= 35)
                        {
                            id++;
                        }
                        Console.WriteLine("Digite sua altura: ");
                        alturaf = double.Parse(Console.ReadLine());
                        feminino++;
                        idademediaf = idademediaf + idadef;
                        malturaf = malturaf + alturaf;
                        break;

                    case 1:
                        Console.WriteLine("Digite sua Idade: ");
                        idadem = int.Parse(Console.ReadLine());
                        if (idadem >= 18 && idadem <= 35)
                        {
                            id++;
                        }
                        Console.WriteLine("Digite sua altura: ");
                        alturam = double.Parse(Console.ReadLine());
                        masculino++;
                        idademediam = idademediam + idadem;
                        malturam = malturam + alturam;
                        break;

                        default:
                        Console.WriteLine("Opçao incorreta, Digite 0 ou 1!\n\n");
                        break;
                }
               
                idade = idademediaf + idademediam;
                i++;
                media = feminino + masculino;
                mediaidd = idade / media;
              
            }
            id1 = (id * 100) / i;
            Console.WriteLine("Media da idade do Grupo: "+ mediaidd.ToString("F2"));
            Console.WriteLine("altura media das mulheres é: " + malturaf / feminino);
            Console.WriteLine("idade media das mulheres é: "+idademediaf/feminino);
            Console.WriteLine("percentual de pessoas com idade entre 18 e 35 anos: {0} % de pessoas! " , id1);
            
           
          
            

        }
    }
}
