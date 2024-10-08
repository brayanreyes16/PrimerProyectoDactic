using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_Vehiculo{
    class Program{
        public static void Main(string[] args){

            Vehiculo carro1 = new Vehiculo("Toyota", "Corolla", 20 ,15000);

            Console.WriteLine($"Ingrese el Numero de dias que Reservo el Vehiculo: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese el porcentaje de Descuento: ");
            double porcentajeDescuento = Convert.ToDouble(Console.ReadLine());

            carro1.MostrarInfo();
            double precio_con_descuento = Vehiculo.Descuento.APDescuento(carro1.Precio, porcentajeDescuento);
            Console.WriteLine($"El Precio con Descuento del carro es de: {precio_con_descuento}");

            double TotalReserva = Reserva.Calcular_CostoReserva(carro1, carro1.Precio_poDia, dias);
            Console.WriteLine($"El Costo total de la reserva por {dias} dias es de: {TotalReserva}$");

            Console.WriteLine($"El Costo Total del vehiculo es de: {precio_con_descuento + TotalReserva} $");
        }
    }
}
