using System;

namespace app_simulador_bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta MinhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Tiago Dantas");

            Console.WriteLine("Hello World!");
        }
    }
}
