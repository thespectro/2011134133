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

            
           
            
            Console.WriteLine("Practica 01");
            GenerateCuentas gen = new GenerateCuentas();
            Console.WriteLine();
            ATM atm = new ATM();
            Console.WriteLine("Cuentas Bancarias (Datos del Login)");
            List<Cuenta> listaCuentas = gen.getListaCuentas();
            BaseDatos bd = new BaseDatos();    
            bd.listaCuentas = listaCuentas;  
            gen.ImprimirCuentas(listaCuentas);  //pasa la listascuentas como parametros para ser impresas
            Console.WriteLine();
            atm.login(bd);


            Console.ReadKey();




        }



      

       
    }
}
