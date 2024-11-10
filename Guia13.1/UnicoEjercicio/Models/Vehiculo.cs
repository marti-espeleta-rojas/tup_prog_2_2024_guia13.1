using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    [Serializable]
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

        public string VerPatente()
        {
            return nroPatente;
        }

        public int CompareTo(Vehiculo vehi)
        {
            if (vehi != null)
            {
                return this.nroPatente.CompareTo(vehi.VerPatente());
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Patente: {nroPatente} - Dueño: {dueño.DNI}";
        }
    }
}
