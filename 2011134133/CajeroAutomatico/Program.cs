using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroAutomatico.Entities;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {

            
           
            
            Console.WriteLine("==========CAJERO USMP=========");
            GenerateCuentas gen = new GenerateCuentas();
            Console.WriteLine();
            ATM atm = new ATM();
            Console.WriteLine("Cuentas Disponibles (Informacion para Login)");
            List<Cuenta> listaCuentas = gen.getListaCuentas();
            BaseDatos bd = new BaseDatos();
            bd.listaCuentas = listaCuentas;
            //imprimiremos las cuentas para poder tener la informacion y loguearnos en el sistema
            gen.ImprimirCuentas(listaCuentas);
            Console.WriteLine();
            atm.login(bd);


            Console.ReadKey();




        }



      

       
    }
}
