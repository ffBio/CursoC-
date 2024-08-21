using System;


namespace CursoCSharp.Classes_Metodos {
    internal class Membros {

        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Fábio";
            sicrano.Idade = 29;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulana = new Pessoa();
            fulana.Nome = "Vikttória";
            fulana.Idade = 24;
            fulana.ApresentarNoConsole();

            var apresentacaoDaFulana = fulana.Apresentar();
            Console.WriteLine(apresentacaoDaFulana.Length);
            Console.WriteLine(apresentacaoDaFulana);
        }
    }
}
