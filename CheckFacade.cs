using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatter
{
    class CheckFacade
    {
        public void Buscar(String fechaDesde, String fechaHasta, String origen, String destino)
        {
            FachadaHoteles hoteles = new FachadaHoteles();
            hoteles.BuscarHoteles(fechaDesde,fechaHasta,destino);
            FachadaAereos aereos = new FachadaAereos();
            aereos.BuscarVuelos(fechaDesde, fechaHasta, origen, destino);
            Console.ReadKey();

        }

    }
}
