﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class ATM
    {

        public RanuraDeposito 
            ranuradeposito { set; get; }
        public Teclado 
            teclado { set; get; }
        public DispensadorEfectivo 
            dispensadorEfectivo { set; get; }
        public Pantalla 
            pantalla { set; get; }


        public void login(BaseDatos bd)
        {
            int nroCuenta;
            int pin;
            String ncuenta, spin;

            while (true)
            {


                Console.WriteLine("Ingresar el Numero de Cuenta luego Presione Enter");
                ncuenta = Console.ReadLine();
                
                int numberException = 0;
                if (int.TryParse(ncuenta, out numberException)) //Valida que el numero de cuenta sea un numero
                { nroCuenta = int.Parse(ncuenta);}      
                else
                {nroCuenta = 0;}

                Console.WriteLine("Ingrese el Pin luego Presione Enter");
                spin=Console.ReadLine();
                if (int.TryParse(spin, out numberException))
                {pin = int.Parse(spin);}
                else
                {pin = 0;}


                if (bd.AutenticarUsuario(nroCuenta, pin))
                {
                    Start(bd, nroCuenta);
                    break;
                }else
                {
                    Console.WriteLine("La Cuenta es Incorrecta");
                  
                }


            }
        }



        public  void Start(BaseDatos bd, int nroCuenta)
        {
            String data;
            Operaciones lib = new Operaciones();
            Console.WriteLine("Elija la operacion que desea Realizar");
            Console.WriteLine("1.Deposito");
            Console.WriteLine("2.Retiro");
            Console.WriteLine("9.Salir");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Ingrese El numero de la Opcion y Presione Enter");
                data = Console.ReadLine();
                if (data.CompareTo("9") == 0)
                {
                    break;
                }
                else if (data.CompareTo("1") == 0)
                {
                    lib.iniciarDeposito(bd, nroCuenta);
                    break;
                }
                else if (data.CompareTo("2") == 0)
                {
                    lib.iniciarRetiro(bd, nroCuenta);
                    break;
                }

            }
        }



    }
}
