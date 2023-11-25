
using PrimeiroProjetos;
using System;
using System.Globalization;
using System.Numerics;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Deseja iniciar o Programa? (s/n)");
            string continua = Console.ReadLine();
            Quartos[] vetor = new Quartos[11];
           
            while (continua == "s")
            {

                Console.WriteLine("ALUGUEL DE QUARTOS -- PROGRAMA");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Quantos quartos serao alugados? (1 - 10) :");
                int n = int.Parse(Console.ReadLine());
                

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("ALUGUEL #" + i);
                    Console.WriteLine("INICIANDO REGISTRO:");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.Write("Informe o Nome :");
                    string name = Console.ReadLine();
                    Console.Write("Informe o Email :");
                    string email = Console.ReadLine();
                    Console.WriteLine("Informe o Quarto");
                    int quarto = int.Parse(Console.ReadLine());
                    vetor[quarto] = new Quartos(name, email);
                }
                Console.WriteLine("");
                Console.WriteLine("QUARTOS OCUPADOS :");
                for (int i = 1; i < 10; i++)
                {
                    if (vetor[i] != null)
                    {
                        Console.WriteLine(i + " : " + vetor[i]);
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("DESEJA CONTINUAR?");
                continua = Console.ReadLine();

            }
            
            

            }
        }
    }

