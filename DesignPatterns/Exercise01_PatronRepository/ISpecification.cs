using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Exercise01_PatronRepository
{
    /*  1. El objetivo del ejercicio es implementar el patron repositorio 
     *  para evaluar si una fecha especifica esta entre un rango de inicio y un rango final.

        2. Crea una interface ISpecification, que tenga un metodo llamado IsValidaFecha(T obj)
        Recibe un parametro generico.

        3. Luego crea una clase implementacion ValidaFechaSpecification 
        implementando la interface ISpecification.

        4. Implementa la logica del metodo IsValidaFecha al interior de la clase ValidaFechaSpecification.
        Esta logica debe devolver un valor true o false, dependiendo si el parametro Datetime esta en 
        un rango de una fecha de inicio y una fecha final.

        Estas fechas de inicio y final deben tener este formato:
            private readonly DateTime _start = new DateTime(2001, 01, 01);
            private readonly DateTime _end = new DateTime(2025, 01, 01);

        Para calcular el resultado, debe evaluar la siguiente condicion:
            bool result = obj >= _start && obj < _end;

        Donde obj es el parametro que representa la fecha a evaluar.
        Luego debe devolver este result.
        
        5. Implementa el patron repositorio en la clase Exercise, en el interior de 
        esta clase crea un metodo Entry Main, para hacer la llamada e instancia de 
        la specification, el parametro que debe enviar es la fecha actual.
    */

    public interface ISpecification<T>
    {
        bool IsValidaFecha(T obj);
    }

}
