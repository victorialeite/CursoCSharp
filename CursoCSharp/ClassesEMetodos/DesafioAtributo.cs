using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        //atributo de instância
        int atributo = 10;

        /*um método que pertence à classe, não consegue acessar diretamente um atributo de 
          instância daquela mesma classe, somente instanciando um objeto dentro dele*/
        public static void Executar()
        {
            DesafioAtributo desafio = new DesafioAtributo();

            //acessar a variável 'a' dentro do método Executar
            Console.WriteLine(desafio.atributo);

            desafio.atributo = 20;

            Console.WriteLine(desafio.atributo);
        }
    }
}
