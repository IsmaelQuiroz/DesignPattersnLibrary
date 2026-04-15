using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    //Interfaz Genérica base
    public interface ISpecificationFechaRango<T>
    {
        //IsSatisfiedBy
        bool IsValidDate(T obj);
    }
}
