using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Estudante: Banco
    {
        public double LimiteChequeEspecial { get; set; }
        public string cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public Estudante() { }

        public Estudante(int numCont, string agencia, string titular, double saldo, double limiteChequeEspecial, string cpf, string nomeInstituicao): base (numCont, agencia, titular, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            this.cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }
        public override double Saque(double valor)
        {
            if (valor > LimiteChequeEspecial)
            {
                Console.WriteLine("O valor não pode ser retirado");
            }
            else 
            {
                Saldo = Saldo - valor;
            }
            return Saldo;
        }
    }
}
