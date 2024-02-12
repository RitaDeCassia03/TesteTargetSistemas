using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Exercicios
{
    public class Exercicio4
    {
        //4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

        //SP – R$67.836,43
        //RJ – R$36.678,66
        //MG – R$29.229,88
        //ES – R$27.165,48
        //Outros – R$19.849,53

        //Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

        public class FaturamentoPorEstado
        {
            public string Estado { get; set; }
            public decimal Valor { get; set; }
        }

        public static void ResultadoPercentualFaturamentoPorEstado()
        {
            List<FaturamentoPorEstado> faturamentoPorEstados = new List<FaturamentoPorEstado>
            {
                new FaturamentoPorEstado { Estado = "SP", Valor = 67836.43m },
                new FaturamentoPorEstado { Estado = "RJ", Valor = 36678.66m },
                new FaturamentoPorEstado { Estado = "MG", Valor = 29229.88m },
                new FaturamentoPorEstado { Estado = "ES", Valor = 27165.48m },
                new FaturamentoPorEstado { Estado = "Outros", Valor = 19849.53m }
            };

            decimal valorTotalMensal = faturamentoPorEstados.Sum(fe => fe.Valor);

            Console.WriteLine("Percentual de Representação por Estado:");
            
            foreach (var estado in faturamentoPorEstados)
            {
                decimal percentual = (estado.Valor / valorTotalMensal) * 100;
                Console.WriteLine($"{estado.Estado}: {percentual:F2}%");
            }
        }
    }
}
