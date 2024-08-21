using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Comentarios{
        public static void Executar() {
            // Nunca fazer comentários desnecessários
            Console.WriteLine("Código claro é lei!");

            ///sumario <summary>
            /// ctrl + space traz opções dentro do summary
            ///sumario final </summary> 
            /*comentário de multiplas linhas em C#
             Assim é o padrão da indústria
            */ 
            Console.WriteLine("O C# tem o XML Comments que é o comentário com // e com /// você faz um sumário");
        }
    }
}
