using DesignPatterns.E03_ISpecificationPattern.BaseSpecifications;
using DesignPatterns.E03_ISpecificationPattern.Models;
using DesignPatterns.E03_ISpecificationPattern.ProductSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E03_ISpecificationPattern.Demo
{
    public class DemoSpecification
    {
        public static void Run()
        {
            //lista de solo lectura con la interface Readonly
            IReadOnlyList<Product> products =
            [
                new() { Name = "A", Price = 50, InStock = true  },
                new() { Name = "B", Price = 200, InStock = false },
                new() { Name = "C", Price = 300, InStock = true  },
                new() { Name = "D", Price = 120, InStock = true  },
                new() { Name = "F", Price = 150, InStock = false  },
                new() { Name = "G", Price = 115, InStock = true  },
                new() { Name = "H", Price = 95, InStock = false  },
                new() { Name = "I", Price = 135, InStock = true  },
                new() { Name = "J", Price = 45, InStock = true  },
                new() { Name = "K", Price = 35, InStock = false  }
            ];

            //creacion de primeras instancias de especificaciónes

            InStockSpecification inStockSpecification = new();
            PriceGreaterThan120Specification priceGreaterThan120Specification = new();          

            //creación de regla compleja o combinada en base a dos reglas simples
            Specification<Product> expensiveProducts = priceGreaterThan120Specification.And(inStockSpecification);

            //ahora vamos a filtrar
            IReadOnlyList<Product> filteredExpensiveProducts = [.. products.Where(expensiveProducts.IsSatisfiedBy)];

            Console.WriteLine("\nPorducts that meets the specification (Price > 120 and In Stock):");
            writeFilteredList(filteredExpensiveProducts);


            /*----------------------------------------------------------------
             * Productos con valor menor a 50 ó en Stock----------------------
             */

            PriceLowerThanXSpecification priceLowerThanXSpecification = new(50);
            Specification<Product> cheaperProducts = priceLowerThanXSpecification.Or(inStockSpecification);

            IReadOnlyList<Product> filterCheaperProductos = products.Where(cheaperProducts.IsSatisfiedBy).ToList();

            Console.WriteLine("\nThe cheaper products where (Price < 50) Or In Stock :");
            writeFilteredList(filterCheaperProductos);
            //foreach (Product product in filterCheaperProductos)
            //    Console.WriteLine($" ==> {product.Name} | {product.Price} | InStock: {product.InStock}");


            /*------------------------------------------------------------------
            * Products that meets the specification ( not in stock ): ----------
            */

            Specification<Product> notAvailableProducst = inStockSpecification.Not();
            IReadOnlyList<Product> filteredNotAvailableProducts = [.. products.Where(notAvailableProducst.IsSatisfiedBy)];
            Console.WriteLine("\nProducts that meets the specification (not in stock): ");
            writeFilteredList(filteredNotAvailableProducts);
        }

        private static void writeFilteredList(IReadOnlyList<Product> producsFiltered)
        {
            foreach (Product product in producsFiltered)
                Console.WriteLine($" ==> {product.Name} | {product.Price} | In Stock: {product.InStock}");
        }
    }
}
