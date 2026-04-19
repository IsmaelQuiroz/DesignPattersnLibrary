using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    public interface ISpecificationNombre<T>
    {
        bool IsValidName(T obj);
    }
}
