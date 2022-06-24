using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {
            string entrada;

            Console.WriteLine("Digite a nota do aluno!");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);


            if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que a obrigação...");
            } else { 
                Console.WriteLine("Recuperação");
            }
        }
    }
}
