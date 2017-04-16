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
            Console.WriteLine("Ingrese el Monto a Retirar luego Presione Enter");
            while (true)
            {
                String data = Console.ReadLine();
                if (int.TryParse(data, out numberException))
                {
                    monto = int.Parse(data);
                    saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                    Console.WriteLine("Saldo antes de la Operacion:".PadRight(31)+" S/." + saldo);
                    if (saldo.CompareTo(monto)<=0)  //se crea un if enviando el monto comparando si el saldo es suficiente para retirar
                    {
                        Console.WriteLine("Saldo Insuficiente"); //al no ser suficiente se muestra este mensaje seguido se mostrara la cantidad que tiene 
                        Console.WriteLine("Debe Ingresar un Monto Menor al Saldo: S/." +saldo+" para Retiro"); //se concatena el saldo para ver con cuanto saldo cuenta
                    }
                    else
                    {

                        bd.Debitar(nroCuenta, monto);
                        saldo = bd.ObtenerSaldoDisponible(nroCuenta);
                        Console.WriteLine("Nuevo Saldo Disponible:".PadRight(31) + " S/." + saldo);
                        Console.WriteLine();
                        Console.WriteLine("Transaccion Terminada, Puede retirar la Tarjeta");
                        break;

                    }

                  
                }
                else
                {
                    Console.WriteLine("Caracter invalido Ingrese un numero"); //si se ingresa una letra o simbolo saldra este mensaje que no corresponde a la cantidad a retirar
                }
            }
            

        }

        public void iniciarDeposito(BaseDatos bd, int nroCuenta)
        {

            int numberException = 0;
            decimal monto = 0;
            decimal saldo;
            Console.WriteLine();
            Console.WriteLine("Ingrese el Monto que desea Depositar y Presione Enter");
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
