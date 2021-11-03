using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatter
{
    class FachadaAereos
    {
        public void BuscarVuelos(String fechaIda, String fechaVuelta, String origen, String destino)
        {
            Console.WriteLine("============");
            Console.WriteLine("Vuelos encontrados para: " + destino + " desde "+ origen);
            Console.WriteLine("Fecha de viaje: " + fechaIda + ",  " + fechaVuelta);
            Console.WriteLine("============");
        }
    }
}
