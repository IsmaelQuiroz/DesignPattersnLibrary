using DesignPatterns.E03_ISpecificationPattern.BaseSpecifications;
using DesignPatterns.E03_ISpecificationPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.ProductSpecifications
{
    internal class PriceGreaterThan120Specification : Specification<Product>
    {
        public override bool IsSatisfiedBy(Product entity)
        {
            return entity.Price > 120;
        }

        //public override bool IsSatisfied(Product entity) => entity.Price > 120;
    }
}
