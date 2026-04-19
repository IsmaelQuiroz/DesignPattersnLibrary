using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E01_RepositoryPattern
{
    public class ValidaFechaSpecification : ISpecification<DateTime>
    {
        private readonly DateTime _start = new DateTime(2001, 01, 01);
        private readonly DateTime _end = new DateTime(2026, 05, 01);

        public bool IsValidaFecha(DateTime obj)
        {
            bool result = obj >= _start && obj < _end;
            return result;
        }
    }
}
