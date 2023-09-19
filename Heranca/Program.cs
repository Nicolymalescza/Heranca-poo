using Heranca;
using System;
using System.ComponentModel;
using System.Drawing;

public class Program
{
    static void Main(string[] args)
    {
        int NumCont = 1;
        string agencia = "Ji-Paraná";
        string cpf = "084.407.542-64";

        Console.Write("\nNome do titular: ");
        string NomeTitular = Console.ReadLine();

        Console.Write("\n\nSaldo: ");
        double saldoCont = Convert.ToDouble(Console.ReadLine());
        while (true) 
        {
            Console.WriteLine("\n\n0 - Sair\n1 - Estudante\n2 - Empresa\n3 - Conta Normal");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                   case 0:
                    goto sair;

                    case 1://Estudante
                    Console.Write("Informe o valor do saque: ");
                    double valorSaqueEst = Convert.ToDouble(Console.ReadLine());
                    Estudante e = new Estudante(007, "1011", NomeTitular,saldoCont, 2000, cpf, agencia);
                    Console.WriteLine($"\nValor final:  {e.Saque(valorSaqueEst).ToString()}\n");
                    break;
          
                case 2://Empresa
                    Console.WriteLine("\n\n1 - Sacar\n2 - Emprestimo");
                    double opc2 = Convert.ToDouble(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        Console.Write("\n\nInforme o valor do saque: ");
                        double valorSaque = Convert.ToDouble(Console.ReadLine());
                        Empresa empre = new Empresa(007, "1011", NomeTitular, saldoCont, 2000, 5000);
                        Console.WriteLine($"\nValor final: {empre.SaqueTaxa(valorSaque).ToString()}\n\n");
                    }
                    else if(opc2 == 2)
                    {
                        Console.Write("\n\nInforme o valor do empréstimo: ");
                        double valordeposito = Convert.ToDouble(Console.ReadLine());
                        Empresa empre = new Empresa(007, "1011", NomeTitular, saldoCont, 2000, 5000);
                        Console.WriteLine($"\nValor final: {empre.Emprestimo(valordeposito).ToString()}\n\n");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nBanco Normal");
                    Banco banco = new Banco(007, "1011", NomeTitular, saldoCont);
                    Console.WriteLine("1- Saque\n2- Deposito");
                    int opcNormal = Convert.ToInt32(Console.ReadLine());

                    if(opcNormal == 1)
                    {
                        Console.Write("\n\nInforme o valor do saque: ");
                        double saque = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(banco.Saque(saque).ToString());                       
                    }
                    else
                    {
                        Console.Write("\n\nInforme o valor do deposito: ");
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(banco.Deposito(deposito).ToString());
                    }
                    break;
            }
        }
         sair:;

        Console.ReadKey();
    }
}