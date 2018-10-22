using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix1
{
    class Conta
    {

        public int numero { get; private set; }
        public string titular{ get; set; }
        public double saldo { get; private set; }

        public Conta(int numero, string titular, double saldo) {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0;
        }

        public void depositarConta(double deposito) {
            this.saldo += deposito;
        }

        public void saqueConta(double saque) {
            this.saldo -= (saque + 5.00);
        }
        public override string ToString()
        {
            return "Conta: " + this.numero +
                    " Nome Titular: " + this.titular +
                    " saldo: " + this.saldo 
                ;
        }

    }
}
