using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class Operaciones
    {

        public void iniciarRetiro(BaseDatos bd, int nroCuenta)
        {
            int numberException = 0;
            decimal monto=0;
            decimal saldo;
            Console.WriteLine();
            Console.WriteLine("Ingrese el Monto a Retirar y Presione Enter");
            while (true)
            {
                String data = Console.ReadLine();
                if (int.TryParse(data, out numberException))
                {
                    monto = int.Parse(data);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Saldo antes de la Operacion:".PadRight(31)+" S/." + saldo);
                    if (saldo.CompareTo(monto)<=0)
                    {
                        Console.WriteLine("Saldo Insuficiente");
                        Console.WriteLine("Debe Ingresar un Monto Menor al Saldo: S/." +saldo+" para Retiro");
                    }
                    else
                    {

                        bd.Debitar(nroCuenta, monto);
                        saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                        Console.WriteLine("Nuevo Saldo Disponible:".PadRight(31) + " S/." + saldo);
                        Console.WriteLine();
                        Console.WriteLine("Operacion Terminada, Retire la Tarjeta");
                        break;

                    }

                  
                }
                else
                {
                    Console.WriteLine("Debe Ingresar un Numero Valido");
                }
            }
            

        }

        public void iniciarDeposito(BaseDatos bd, int nroCuenta)
        {

            int numberException = 0;
            decimal monto = 0;
            decimal saldo;
            Console.WriteLine();
            Console.WriteLine("Ingrese el Monto a Depositar y Presione Enter");
            while (true)
            {
                String data = Console.ReadLine();
                if (int.TryParse(data, out numberException))
                {
                    monto = int.Parse(data);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Saldo antes de la Operacion:".PadRight(31)+" S/." + saldo);                    

                        bd.Acreditar(nroCuenta, monto);
                        saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                        Console.WriteLine("Nuevo Saldo Disponible:".PadRight(31) + " S/." + saldo);
                        Console.WriteLine();
                        Console.WriteLine("Operacion Terminada, Retire la Tarjeta");
                        break;
                }
                else
                {
                    Console.WriteLine("Debe Ingresar un Numero Valido");
                }
            }

        }
    }
}
