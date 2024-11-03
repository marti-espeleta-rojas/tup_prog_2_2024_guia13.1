using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    public abstract class Ticket
    {
        protected int nroOrden; //este número es asignado en el momento en que incremento el contador estático de clases derivadas para cada entidad
        private DateTime fechaHora;

        public int VerNro()
        {
            return nroOrden;
        }

        public DateTime VerFechaHora()
        {
            return fechaHora;
        }
    }
}
