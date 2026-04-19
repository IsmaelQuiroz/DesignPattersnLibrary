using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.BaseSpecifications
{
    /*En Base Specifications Folder, se almacenarán condiciones específicas para determinar si una Entidad
        Cumple con una especificacion, una regla (Reglas de negocio o Criterios) que podemos almacenar 
        en objetos reutilizables y combinables entre si

        Las 3 formas más comunes de organizar y combinar son AND , OR y NOT
    */
    //https://github.com/UskoKruM/csharp-net-design-pattern-specification-example/blob/master/Specifications/Base/OrSpecification.cs
    
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);


        //public Specification<T> And(Specification<T> other)
        //    => new AndSpecification<T>(this, other);

        public Specification<T> And(Specification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        //this indica "toma esta regla actual y combínala con la siguiente"
        public Specification<T> Or(Specification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }

        public Specification<T> Not()
        {
            return new NotEspecification<T>(this);
        }

    }
}
