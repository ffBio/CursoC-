using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Modelo, string fabricante, int ano) {   //construtor
            this.Modelo = Modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { }  //contrutor 
    }
    internal class Construtores {

        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "X6";
            carro1.Ano = 2024;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2022);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
