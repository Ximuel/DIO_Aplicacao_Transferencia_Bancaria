using System;
using System.Collections.Generic;
using DIO.bank.conta;

namespace DIO.bank
{
      public enum TipoConta
    {
      PessoaFisica = 1,

      PesosaJuridica = 2

    }

    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    ListarContas();
                    break;
                    case "2":
                    InserirConta();
                    break;
                    case "3":
                    Transferir();
                    break;
                    case "4":
                    Sacar();
                    break;
                    case "5":
                    Depositar();
                    break;
                    case "C":
                    Console.Clear();
                    break;
                    default:
                    throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();
            }  

            System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadKey();
        }

        private static void InserirConta()
        {
            System.Console.WriteLine("Insira 1 para pessoa fisica e 2 para pessoa juridica:");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o nome do cliente:");
            string entradaNome = Console.ReadLine();
            System.Console.WriteLine("Digite o saldo inicial:");
            double entradaSaldo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o crédito:");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaconta = new Conta(tipoConta: (TipoConta)entradaTipoConta, saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);
        }

        private static string ObterOpcaoUsuario()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("DIO Bank ao seu dispor!");
        System.Console.WriteLine("Informe a opção desejada:");
        System.Console.WriteLine("1 - Listar contas");
        System.Console.WriteLine("2 - Inserir nova conta");
        System.Console.WriteLine("3 - Transferir");
        System.Console.WriteLine("4 - Sacar");
        System.Console.WriteLine("5 - Depositar");
        System.Console.WriteLine("C - Limpar tela");
        System.Console.WriteLine("X - Sair");
        System.Console.WriteLine();
        string opcaousuario = Console.ReadLine().ToUpper();
        return opcaousuario;
    }
    }


}
