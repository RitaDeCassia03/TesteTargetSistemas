using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Exercicios
{
    public class Exercicio5
    { 
        //5) Escreva um programa que inverta os caracteres de um string.

        //IMPORTANTE:
        //a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
        //b) Evite usar funções prontas, como, por exemplo, reverse;

        public static void StringInvertida()
        {
            Console.Write("Informe uma string: ");
            string inputString = Console.ReadLine();

            string reversedString = InverterString(inputString);
            Console.WriteLine($"String Invertida: {reversedString}");
        }

        static string InverterString(string input)
        {
            char[] caracteres = input.ToCharArray();

            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;

                inicio++;
                fim--;
            }

            return new string(caracteres);
        }
    }
}
