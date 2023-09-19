using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Empresa : Banco
    {
        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public Empresa() { }
        public Empresa(int numCont, string agencia, string titular, double saldo, double taxaAnuidade, double limiteEmprestimo) : base(numCont, agencia, titular, saldo)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
        }

        public double Emprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo - TotalEmprestimo)
            {
                Saldo += valor;
                TotalEmprestimo += valor;
                Console.WriteLine("O empréstimo foi realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido\nSaldo insuficiente!");
            }
            return TotalEmprestimo;
        }

        public double SaqueTaxa(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo -= valor;
                if(valor >= 5000)
                {
                    return Saldo -= 5;
                }               
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            return Saldo;
        }
    }   
}