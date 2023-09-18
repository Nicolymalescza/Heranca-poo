using Heranca;
using System;
public class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("0 - Sair\n1 - Estudante\n2 - Empresa");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                   case 0:
                    goto sair;

                    case 1:
                    Console.Write("Informe o valor do saque: ");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());
                    Estudante e = new Estudante();
                    e.Saque(valorSaque);
                    break;

                    case 2:

                    break;
            }

        }
         sair:;
        









        Console.ReadKey();
    }
}