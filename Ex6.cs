using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace ExerciciosPraticos2
{
    internal class Ex6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Função que escreve todos os números multiplos de 19 até 2000");

            
            escreveNumeros();
        
        }


        static void escreveNumeros()
        {
            Console.WriteLine("Os múltiplos de 19 são");

            for (int i = 19; i < 2000; i=i+19)
            {

                Console.Write(i + " ");
            }

        }
    }
}