using Heranca;
using System;
public class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("\n\n0 - Sair\n1 - Estudante\n2 - Empresa");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                   case 0:
                    goto sair;

                    case 1:
                    Console.Write("Informe o valor do saque: ");
                    double valorSaqueEst = Convert.ToDouble(Console.ReadLine());
                    Estudante e = new Estudante(007, 1011, "Nicoly", /*saldo*/15000, /*limite cheque especial*/20000, "000.000.000-00", "Caixa");
                    Console.WriteLine($"\nValor final:  { e.Saque(valorSaqueEst).ToString()}\n");
                    break;

                   
                case 2:
                    Console.WriteLine("1 - Sacar\n2 - Emprestimo");
                    double opc2 = Convert.ToDouble(Console.ReadLine());
                    if (opc2 == 1)
                    {
                        Console.Write("Informe o valor do saque: ");
                        double valorSaque = Convert.ToDouble(Console.ReadLine());
                        Empresa empre = new Empresa(007, 1011, "Nicoly", 15000, 20000, 50000, 50000);
                        Console.WriteLine($"\nValor final: {empre.SaqueTaxa(valorSaque).ToString()}\n\n");
                    }
                    else if(opc2 == 2)
                    {
                        Console.Write("Informe o valor do empréstimo: ");
                        double valordeposito = Convert.ToDouble(Console.ReadLine());
                        Empresa empre = new Empresa(007, 1011, "Nicoly", 15000, 20000, 50000, 50000);
                        Console.WriteLine($"\nValor final: {empre.Emprestimo(valordeposito).ToString()}\n\n");
                    }

                    break;
            }

        }
         sair:;

        Console.ReadKey();
    }
}