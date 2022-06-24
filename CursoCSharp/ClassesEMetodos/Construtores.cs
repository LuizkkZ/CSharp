using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;
    }

    internal class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "Mercedez Benz";
            carro1.Modelo = "G63";
            carro1.Ano = 2022;
            Console.Write($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");
        }
    }
}
//bloco12