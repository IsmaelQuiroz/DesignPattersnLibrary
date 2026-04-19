using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    public class Evento
    {
        public string Nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}
