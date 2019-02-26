using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ContaCorrente conta = new ContaCorrente(123, 332211);
              {
                  Console.WriteLine("O número da agencia é: " + conta.Agencia);
                  Console.WriteLine("O número da conta é: " + conta.Numero);
              }
              */

            DateTime dataFimPagamento = new DateTime(2019, 10, 15);

            DateTime dataCorrente = DateTime.Now;

            Console.WriteLine("Data corrente: " + dataCorrente);

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.WriteLine("Vencimento em: " + diferenca);
            
        }
    }
}
