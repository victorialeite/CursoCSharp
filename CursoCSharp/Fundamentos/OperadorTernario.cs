﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
            
            bool bomComportamento = false;
            resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
