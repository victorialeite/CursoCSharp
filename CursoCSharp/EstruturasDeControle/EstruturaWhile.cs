using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if(numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else
                {
                    if(palpite > numeroSecreto)
                    {
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Menor... Tente novamente!");
                        Console.BackgroundColor = corAnterior;
                        Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                        Console.WriteLine();
                    }
                    else
                    {
                        var corAnterior = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Maior... Tente novamente!");
                        Console.BackgroundColor = corAnterior;
                        Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
