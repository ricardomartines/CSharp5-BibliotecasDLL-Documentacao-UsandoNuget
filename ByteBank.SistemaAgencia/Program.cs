using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 332211);
            {
                Console.WriteLine("O número da agencia é: " + conta.Agencia);
                Console.WriteLine("O número da conta é: " + conta.Numero);
            }
            
        }
    }
}
