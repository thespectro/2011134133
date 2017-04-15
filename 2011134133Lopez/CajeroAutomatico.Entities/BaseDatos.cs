using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class BaseDatos
    {
        public List<Cuenta> listaCuentas { set; get; }

        //definimos autenticar usuario Mediante una busqueda secuencial del nro de cuenta y el nro de pin
        public bool AutenticarUsuario(int nroCuenta, int pin)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].getNroCuenta() == nroCuenta  && listaCuentas[i].getPin() == pin)
                {
                    return true;
                }
            }
                return false;
        }

        public void agregarCuenta(Cuenta cuenta){
            this.listaCuentas.Add(cuenta);
        }
        //Obtenemos el saldo tambien realizando una busqueda

        public decimal ObtenerSaldoDisponible(int nroCuenta)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].getNroCuenta() == nroCuenta)
                {
                    return listaCuentas[i].getSaldo();
                }
            }
            return 0;
        }


        //debitamos el monto de la cuenta, previamente debemos haber validado que haya saldo disponible

        public void Debitar(int nroCuenta, decimal monto)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].getNroCuenta() == nroCuenta)
                {
                    listaCuentas[i].DebitarMonto(monto);
                }
            }
        }

        //acreditamos el monto  a la cuenta
        public void Acreditar(int nroCuenta, decimal monto)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].getNroCuenta() == nroCuenta)
                {
                    listaCuentas[i].AcreditarMonto(monto);
                }
            }
        }

    }
}
