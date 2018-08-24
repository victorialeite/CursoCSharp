using System;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo";
            Console.WriteLine(nome);

            /* Errado:
             * var nome;
             * nome = "Leonardo";
             * 
             * ou
             * 
             * var nome = "Leonardo";
             * nome = 2;
             */
        }
    }
}
