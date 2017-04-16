using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Cuenta
    {
        private int nroCuenta;
        private int pin;
        private decimal saldo;

        public Cuenta(int nroCuenta, int pin, decimal saldo)
        {
            this.nroCuenta = nroCuenta;
            this.pin = pin;
            this.saldo = saldo;
        }

        public void DebitarMonto(decimal monto)
        {
            this.saldo = saldo-monto;
        }

        public void AcreditarMonto(decimal monto)
        {
            this.saldo = saldo + monto;
        }

        public int getPin()
        {
            return pin;
        }

        public int getNroCuenta()
        {
            return nroCuenta;
        }

        public decimal getSaldo()
        {
            return saldo;
        }
    }
}
