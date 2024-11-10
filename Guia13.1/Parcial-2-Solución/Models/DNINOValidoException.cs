using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException():base("El DNI no es válido") { }
        public DNINoValidoException(string msg) : base(msg) { }
        public DNINoValidoException(string msg, Exception ez) : base(msg, ez) { }
    }
}
