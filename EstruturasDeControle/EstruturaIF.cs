﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIF {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Aluno possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            if(entrada == "S" || entrada == "s") {
                bomComportamento = true;
            }
            if(nota >= 6.0 && bomComportamento) {
                Console.WriteLine("Parabéns pelo esforço!");
            }
            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}
