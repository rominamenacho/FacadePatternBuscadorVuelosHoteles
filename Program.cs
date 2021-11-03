using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatter
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFacade cliente1 = new CheckFacade();
            cliente1.Buscar("28/12/2021", "19/01/2022", "MDZ", "CARG");
        }
    }
}
