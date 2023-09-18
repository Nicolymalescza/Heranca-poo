using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Banco
    {
        public int NumCont { get; set; }
        public int Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public Banco() { }

        public Banco(int numCont, int agencia, string titular, double saldo)
        {
            this.NumCont = numCont;
            this.Agencia = agencia;
            this.Titular = titular;
            this.Saldo = saldo;
        }   

        public double Deposito(double valor)
        {
            if(valor >= 0)
            {
                return Saldo += valor;
            }
            else
            {
                Console.WriteLine("Opção Inválida!");
            }
            return Saldo;
        }

        public virtual double Saque(double sacar)
        {
            if (sacar <= Saldo)
            {
                Saldo -= sacar;
            }
            else if (Saldo < sacar)
            {
                Console.WriteLine("Saldo insuficiente\nNão é possível concluir a ação");
            }
            return Saldo;
        }
    }
}