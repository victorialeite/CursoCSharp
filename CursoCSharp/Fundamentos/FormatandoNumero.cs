using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            // imprime apenas uma casa decimal, arredondando o numero
            Console.WriteLine(valor.ToString("F1"));
            // imprime o numero como valor monetário
            Console.WriteLine(valor.ToString("C"));
            // imprime o numero como valor percentual
            Console.WriteLine(valor.ToString("P"));
            // imprime no formato desejado
            Console.WriteLine(valor.ToString("#.##"));

            // imprime o numero como valor monetário de acordo com o país que está nos parâmetros
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));            
            CultureInfo cultura2 = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", cultura2));

            int inteiro = 256;
            // completa o numero com zeros a esquerda, formando um numero com a quantidade de caracteres desejada
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
