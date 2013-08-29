using System;

namespace ProblemaEuler2_EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const float termoMaximo = 4000000;
            float termoAnterior = 1;
            float termoAtual = 1;
            float somaDosTermosPares = 0;

            while (termoAtual < termoMaximo)
            {
                float novoTermo = termoAnterior + termoAtual;

                termoAnterior = termoAtual;
                termoAtual = novoTermo;

                if (termoAtual % 2 == 0)
                    somaDosTermosPares += termoAtual;
            }

            Console.WriteLine("A soma dos elementos pares da sequência de Fibonacci entre 1 e 4 milhoes é: {0}", somaDosTermosPares);
            Console.ReadLine();
        }
    }
}
