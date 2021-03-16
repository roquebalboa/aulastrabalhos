using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bidu = new cachorro();
            bidu.nome = "Bidu da Silva";
            bidu.raça = "Pit-bull";
            bidu.genero = "macho";
            bidu.idade = 3;

            bidu.abanarrabo();
            bidu.Latir();


        }
    }
}
