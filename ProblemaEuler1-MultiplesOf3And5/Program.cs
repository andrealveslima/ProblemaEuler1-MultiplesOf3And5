using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaEuler1_MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaDosMultiplos = 0;

            // Para cada número entre 1 e 999.
            for (int contador = 1; contador < 1000; contador++)
                // Se o número for múltiplo de 3 ou 5, acrescentar no sumarizador.
                if (contador % 3 == 0 || contador % 5 == 0)
                    somaDosMultiplos += contador;

            Console.WriteLine("A soma de todos os múltiplos de 3 ou 5 entre 1 e 999 é {0}", somaDosMultiplos);
            Console.ReadLine();
        }
    }
}
