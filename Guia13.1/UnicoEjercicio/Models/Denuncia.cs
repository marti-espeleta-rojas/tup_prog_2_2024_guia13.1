using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    [Serializable]
    public class Denuncia : Ticket
    {
        private Vehiculo dominio;
        private static int numero; 

        public Denuncia(Vehiculo dominio)
        {
            numero++;
            this.dominio = dominio;
            nroOrden = numero;
        }
    }
}
