using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, in int b) { 
            return a * b; 
        }
    }
    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 7);
            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraEstatica.Somar(10, 2));
        }
    }
}
