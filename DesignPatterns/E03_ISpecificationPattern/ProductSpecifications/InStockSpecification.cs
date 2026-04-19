using DesignPatterns.E03_ISpecificationPattern.BaseSpecifications;
using DesignPatterns.E03_ISpecificationPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.ProductSpecifications
{
    //InStockSpecification() : Hereda del  modelo base Specificaction<> y le paso como generico/clase/tipo el Product
    public sealed class InStockSpecification() : Specification<Product>
    {
        //la sobreescritura del metodo pasandole la clase una instancia  de Product 
        public override bool IsSatisfiedBy(Product entity)
        {
            return entity.InStock; //lo que estoy devolviendo o la regla que estoy cumpliendo es que (InStock sea true)
        }
        
        //asi se haria con arrow functi  ons
        //public override bool IsSatisfiedBy(Product product) => product.InStock;
    }
}
