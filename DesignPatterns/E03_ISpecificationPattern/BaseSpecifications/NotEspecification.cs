using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.BaseSpecifications
{
    public sealed class NotEspecification<T>(Specification<T> spec) : Specification<T>
    {
        public override bool IsSatisfiedBy(T entity)
        {
           return !spec.IsSatisfiedBy(entity);
        }
    }
}
