using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    public class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException() : base("El DNI es inválido. Intente nuevamente ingresando un DNI válido") { }
        public DNINoValidoException(string msg) : base(msg) { }
        public DNINoValidoException(string msg, Exception inner) : base(msg, inner) { }
    }
}
