using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public class CuentaInexistenteException : ApplicationException
    {
        public CuentaInexistenteException() : base("Cuenta Inexistente") { }
        public CuentaInexistenteException(string message) : base(message) { }
        public CuentaInexistenteException(string message, Exception ex) : base(message, ex) { }
    }
}
