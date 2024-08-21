﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Somar(int c, int d, int e) {
            return c + d + e;
        }

        public int Subtrair(int a, int b) {
            return a - b; 
        }

        public int Multiplicar(int a, int b) {
            return a * b; 
        }

        public int Dividir(int a, int b) {
            return  a / b; 
        }

        class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar(int a) {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado() {
                return memoria; 
            }
        }

        internal class MetodosComRetorno {
        public static void Executar() {
                var calculadoraComum = new CalculadoraComum();
                var resultado = calculadoraComum.Somar(10, 10);
                Console.WriteLine(resultado);
                Console.WriteLine(calculadoraComum.Subtrair(10, 15));
                Console.WriteLine(calculadoraComum.Multiplicar(10, 15));
                Console.WriteLine(calculadoraComum.Dividir(100, 15));

                var calculadoraCadeia = new CalculadoraCadeia();
                calculadoraCadeia.Somar(3).Multiplicar(10).Imprimir().Limpar().Imprimir();

                resultado = calculadoraCadeia.Somar(5).Multiplicar(10).Resultado();
                Console.WriteLine(resultado);
            }

    }
    }
}