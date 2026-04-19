using DesignPatterns.E03_ISpecificationPattern.BaseSpecifications;
using DesignPatterns.E03_ISpecificationPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.ProductSpecifications
{
    public sealed class PriceLowerThanXSpecification(decimal x) : Specification<Product>
    {
        public override bool IsSatisfiedBy(Product entity)
        {
            return entity.Price < x;
        }

        //public override bool IsSatisfiedBy(Product entity) => entity.Price < x;
    }

}
