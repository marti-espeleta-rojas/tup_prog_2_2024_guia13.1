using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    [Serializable]
    public class Cliente : Ticket, IComparable<Cliente>
    {
        private long dni;
        private static int numero;

        public long DNI
        {
            get
            {
                return dni;
            }
        }

        public Cliente(long dni)
        {
            if(dni > 5000000 || Regex.Match(dni.ToString(), @"^[0-9]{6,8}$").Success)
            {
                this.dni = dni;
                numero++;
                nroOrden = numero;
            }
            else
            {
                throw new DNINoValidoException();
            }
        }

        public int CompareTo(Cliente cli)
        {
            return this.dni.CompareTo(cli.DNI);
        }

        public override string ToString()
        {
            return $"DNI: {dni}";
        }
    }
}
