using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.Models
{
    public sealed class Product //Sealed: la clase no puede ser heredada
    {
        public string Name { get; init; } = "";
        public decimal Price { get; init; }
        public bool InStock { get; init; }
    }
}
