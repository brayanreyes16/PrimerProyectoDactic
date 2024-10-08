using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_Vehiculo{
    public static class Reserva{

        public static double Calcular_CostoReserva(Vehiculo vehiculo, double Precio_poDia,int dias)
        {
        double costototal = Precio_poDia* dias;
        return costototal;
        }
    }
}
