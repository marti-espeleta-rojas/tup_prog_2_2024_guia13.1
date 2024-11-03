using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    public class Vehiculo : IComparable<Vehiculo>
    {
        private string nroPatente;
        private Cliente dueño;

        public Vehiculo(string patente, Cliente cliente)
        {
            nroPatente = patente;
            dueño = cliente;
        }

        public Cliente VerDueño()
        {
            return this.dueño;
        }

        private string VerPatente()
        {
            return nroPatente;
        }

        public int CompareTo(Vehiculo vehi)
        {
            return this.nroPatente.CompareTo(vehi.VerPatente());
        }

        public override string ToString()
        {
            return $"Patente: {nroPatente} - Dueño: {dueño.DNI}";
        }
    }
}
