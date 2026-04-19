using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.BaseSpecifications
{
    public sealed class AndSpecification<T>(
        Specification<T> left,
        Specification<T> right) : Specification<T>
    {
        public override bool IsSatisfiedBy(T entity)
        {
            return left.IsSatisfiedBy(entity) && right.IsSatisfiedBy(entity);
        }
    }
}
