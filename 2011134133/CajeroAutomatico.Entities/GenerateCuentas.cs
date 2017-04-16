using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    public class GenerateCuentas
    {

        public List<Cuenta> getListaCuentas()
        {
            List <Cuenta> listaCuentas= new List<Cuenta>(); // se crea la lista con los datos de de la cuenta el ping y el monto

            Cuenta cuenta1 = new Cuenta(0123456789, 1234, 1680);
            Cuenta cuenta2 = new Cuenta(1123456789, 1235, 8520);
            Cuenta cuenta3 = new Cuenta(2123456789, 1236, 98745);
            Cuenta cuenta4 = new Cuenta(312345679, 1237, 2544);
            Cuenta cuenta5 = new Cuenta(412345679, 1238, 680);
            Cuenta cuenta6 = new Cuenta(512345679, 1239, 7444);

            listaCuentas.Add(cuenta1);   // se pasa como parametro cada cuenta a la listaCuentas
            listaCuentas.Add(cuenta2);
            listaCuentas.Add(cuenta3);
            listaCuentas.Add(cuenta4);
            listaCuentas.Add(cuenta5);
            listaCuentas.Add(cuenta6);


            return listaCuentas;   // por ultimo se retorna la lista
        }


        public void ImprimirCuentas(List<Cuenta>listacuentas)         //se pasa como parametro la lista que se mostrara 
        {
            Console.WriteLine("NroCuenta".PadRight(15)+"Pin".PadRight(10)+"Saldo".PadRight(10));  //para identificar el numero de cuenta pin y sado se pone estas "columnas"
            for (int i = 0; i < listacuentas.Count; i++)  // se va llenado cada "columna" 
            {
                Console.WriteLine(listacuentas[i].getNroCuenta().ToString().PadRight(15)+listacuentas[i].getPin().ToString().PadRight(10)+listacuentas[i].getSaldo().ToString().PadRight(10)); //se mostrara en consola las cuentas disponibles pasando como parametro la poscion
            }
        }
    }
}
