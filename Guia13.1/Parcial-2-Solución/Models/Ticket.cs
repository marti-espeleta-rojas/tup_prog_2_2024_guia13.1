using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public abstract class Ticket
    {
        protected int nroOrden;
        DateTime fechaHora;

        public Ticket() //se va a llamar a este constructor implícitamente a través de sus constructores de clases derivadas
        {
            fechaHora = DateTime.Now;
        }

        public int VerNro()
        {
            return nroOrden;
        }

        public DateTime VerFechaHora()
        {
            return fechaHora;
        }

        public override string ToString()
        {
            return $"{nroOrden} {fechaHora}";
        }
    }
}
