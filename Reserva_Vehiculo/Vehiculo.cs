using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_Vehiculo{

    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public double Precio { get; set;}
        public double Precio_poDia { get; set;}

        public Vehiculo(string marca, string modelo, double tarifa_reservadiaria, double precio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio_poDia= tarifa_reservadiaria;
            Precio= precio;
        }

        internal class Descuento
        {
            public static double APDescuento(double precio, double porcentajeDescuento)
            {
                double precio_descuento = precio - (precio*(porcentajeDescuento / 100));
                return precio_descuento;
            }
        }
    }

    public  static class Extension{
        public static void MostrarInfo(this Vehiculo vehiculo){
            Console.WriteLine($"Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Tarifa de Reserva: {vehiculo.Precio_poDia} $ por dia,  Precio: {vehiculo.Precio} $");
        }
    }
}
