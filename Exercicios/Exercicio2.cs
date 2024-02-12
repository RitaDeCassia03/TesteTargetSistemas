using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Exercicios
{
    public class Exercicio2
    {
        //2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2
        //valores anteriores(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde,
        //informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

        //IMPORTANTE:
        //Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

        public static void ExecutarVerificacaoFibonacci()
        {
            Console.Write("Informe um número: ");
            int numeroInformado = Convert.ToInt32(Console.ReadLine());

            if (NumeroInformadoPertenceASequencia(numeroInformado))
            {
                Console.WriteLine($"{numeroInformado} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numeroInformado} não pertence à sequência de Fibonacci.");
            }
        }

        public static bool NumeroInformadoPertenceASequencia(int num)
        {
            int a = 0, b = 1;

            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == num;
        }
    }
}
