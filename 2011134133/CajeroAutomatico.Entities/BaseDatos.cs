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

        
        public bool AutenticarUsuario(int nroCuenta, int pin) // se identifica al usuario segun sus datos
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
        

        public decimal ObtenerSaldoDisponible(int nroCuenta)  // se envia el numero de cuenta para saber el saldo disponible
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


        

        public void Debitar(int nroCuenta, decimal monto)  //segun el saldo disponilbe se resta la cantidad del monto de la cuenta
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                if (listaCuentas[i].getNroCuenta() == nroCuenta)
                {
                    listaCuentas[i].DebitarMonto(monto);
                }
            }
        }

        
        public void Acreditar(int nroCuenta, decimal monto) // lo contrario al anterior osea se le suma 
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
