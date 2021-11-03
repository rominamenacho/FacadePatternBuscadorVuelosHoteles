using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatter
{
    class FachadaHoteles
    {
        public void BuscarHoteles(String fehcaIda, String fechaHasta, String destino)
        {
            Console.WriteLine("============");
            Console.WriteLine("Hoteles encontrados para: "+ destino );
            Console.WriteLine("Fecha de llegada: "+ fehcaIda + ", salida "+ fechaHasta);
            Console.WriteLine("============");
            
        }
    }
    
}
