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
        public Empresa(int numCont, int agencia, string titular, double saldo, double taxaAnuidade, double limiteEmprestimo, double totalEmprestimo) : base( numCont,  agencia,  titular,  saldo)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public double Emprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo)
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
            if(valor >= 5000.00)
            {
                return Saldo - (valor + 5);
            }
            return Saldo;
        }
    }   
}