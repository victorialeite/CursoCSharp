using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // idem a: num1 = num1 + 10;
            num1 -= 3; // idem a: num1 = num1 - 3;
            num1 *= 5; // idem a: num1 = num1 * 5;
            num1 /= 2; // idem a: num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // incremento: a = a + 1;
            b--; // decremento: b = b - 1;

            Console.WriteLine($"{a} {b}");

            // Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            //atribuição por referencia
            dynamic d = c;            
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
