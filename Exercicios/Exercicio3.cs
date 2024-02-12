using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Exercicios
{
    public class Exercicio3
    {
        //3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
        //• O menor valor de faturamento ocorrido em um dia do mês;
        //• O maior valor de faturamento ocorrido em um dia do mês;
        //• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

        //IMPORTANTE:
        //a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
        //b) Podem existir dias sem faturamento, como nos finais de semana e feriados.Estes dias devem ser ignorados no cálculo da média;
        public class FaturamentoDiario
        {
            public int Dia { get; set; }
            public decimal Valor { get; set; }
        }

        public static void FaturamentoDiarioResultado()
        {
            string caminhoArquivo = @"H:\Projetos\TesteTargetSistemas\dados.json";

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                List<FaturamentoDiario> faturamentoDiarioList = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

                if (faturamentoDiarioList.Count > 0)
                {
                    CalcularExibirResultados(faturamentoDiarioList);
                }
                else
                {
                    Console.WriteLine("Nenhum dado de faturamento encontrado.");
                }
            }
            else
            {
                Console.WriteLine($"Arquivo '{caminhoArquivo}' não encontrado.");
            }
        }

        static void CalcularExibirResultados(List<FaturamentoDiario> faturamentoDiarioList)
        {
            decimal mediaMensal = CalculoMedia(faturamentoDiarioList);

            decimal menorValor = faturamentoDiarioList.Where(fd => fd.Valor > 0).Min(fd => fd.Valor);
            decimal maiorValor = faturamentoDiarioList.Max(fd => fd.Valor);

            int diasSuperiorMedia = faturamentoDiarioList.Count(fd => fd.Valor > mediaMensal);

            Console.WriteLine($"Menor valor de faturamento: {menorValor}");
            Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
            Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasSuperiorMedia}");
        }

        static decimal CalculoMedia(List<FaturamentoDiario> faturamentoDiarioList)
        {
            decimal somaValores = 0;
            int contadorValores = 0;

            foreach (var faturamentoDiario in faturamentoDiarioList)
            {
                if (faturamentoDiario.Valor > 0)
                {
                    somaValores += faturamentoDiario.Valor;
                    contadorValores++;
                }
            }

            decimal mediaMensal;

            if (contadorValores > 0)
            {
                mediaMensal = somaValores / contadorValores;
                return mediaMensal;
            }
            else
            {
                return 0;
            }
        }
    }
}
