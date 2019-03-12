using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeIntereses
{
    class Comprobante
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Comprobantes");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese Fecha: ");


            DateTime fecha1 = new DateTime();
            fecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(fecha1);
            DateTime fecha2 = DateTime.Now;
            TimeSpan difFechas = fecha2 - fecha1;
            int dias = difFechas.Days;
            Console.WriteLine(fecha2);
            Console.WriteLine(dias);
           
           
           
            

            int menor = 0;
            int iva = 0;
            double total = 0;
            //int operacion = int.Parse(Console.ReadLine());

            //Pagar(operacion);
            //int pagar = 0;
            //Pagar(pagar);


            if (menor == 0)
            {
                if (fecha1 <= fecha2)
                {
                    menor = fecha1.Day;
                }

            }

                //int pagare = 0;
                ////Console.Write("Debera pagar : ");
                //////pagare = Convert.ToInt32(Console.ReadLine());
                ////pagare = int.Parse(Console.ReadLine());
                //Console.Write("Ingrese el primer numero: ");
     
                Console.ReadKey();
        }

    }
}
