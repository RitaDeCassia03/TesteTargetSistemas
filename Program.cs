using TesteTargetSistemas.Exercicios;
namespace TesteTargetSistemas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarExecucao = true;

            while (continuarExecucao)
            {
                Console.WriteLine("2. Exercicio 2 - Fibonacci");
                Console.WriteLine("3. Exercicio 3 - Faturamento Diario");
                Console.WriteLine("4. Exercicio 4 - Faturamento Por Estados");
                Console.WriteLine("5. Exercicio 5 - String Invertida");

                Console.Write("\nEscolha uma opção (entre 2 e 5): ");
                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha >= 2 && escolha <= 5)
                {
                    switch (escolha)
                    {
                        case 2:
                            Console.WriteLine("\nExecutando função para Exercicio 2");
                            Exercicio2.ExecutarVerificacaoFibonacci();
                            break;
                        case 3:
                            Console.WriteLine("\nExecutando função para Exercicio 3");
                            Exercicio3.FaturamentoDiarioResultado();
                            break;
                        case 4:
                            Console.WriteLine("\nExecutando função para Exercicio 4");
                            Exercicio4.ResultadoPercentualFaturamentoPorEstado();
                            break;
                        case 5:
                            Console.WriteLine("\nExecutando função para Exercicio 5");
                            Exercicio5.StringInvertida();
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Console.Write("\nDeseja repetir (S para Sim, qualquer outra tecla para Não)? ");
                    string resposta = Console.ReadLine().ToUpper();
                    continuarExecucao = resposta == "S";
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Escolha um número entre 2 e 5.");
                }
            }

            Console.WriteLine("\nPrograma encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
