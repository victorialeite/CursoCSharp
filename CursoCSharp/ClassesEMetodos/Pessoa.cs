using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; //valor padrao null
        public int Idade; //valor padrao 0

        public string Apresentar()
        {
            if (this.Nome != null && this.Idade != 0)
                return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            else
                return string.Format("Informações inválidas.");
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }

        //não recomendado
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        } 
    }
}
