using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    public class SpecificationNombre : ISpecificationNombre<Evento>
    {
        private readonly string _nombre;

        public SpecificationNombre(string nombre) { 
            _nombre = nombre;
        }

        public bool IsValidName(Evento obj)
        {
            return (obj.Nombre.Contains(_nombre));
        }
    }
}
