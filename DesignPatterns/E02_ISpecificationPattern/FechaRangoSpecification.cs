using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.E02_ISpecificationPattern
{
    //Clase que implementa la interface especificación  y evaluación del metodo IsSatisfiedBy 
    //Llamada tambien especificación concreta para evaluar fecha
    public class FechaRangoSpecification : ISpecificationFechaRango<Evento>
    {
        private readonly DateTime _dateToEval;

        //asigna el parametro fecha a evaluar a la propiedad privada de la clase
        public FechaRangoSpecification(DateTime dateToEval)
        {
            _dateToEval = dateToEval;
        }

        // metodo hace la validación de la propiedad de fecha a evaluar
        public bool IsValidDate(Evento obj)
        {
            return (_dateToEval >= obj.fechaInicio && _dateToEval <= obj.fechaFin);
        }

    }
   
}
