using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public class Cliente : Ticket
    {
        static int nroInicio;
        int dni;

        public Cliente(int dni)
        {
            if(dni > 3000000 && dni < 450000000)
            {
                this.dni = dni;
                nroInicio++;
                nroOrden = nroInicio;
            }
            else
            {
                throw new DNINoValidoException();
            }
        }

        public override string ToString()
        {
            return $"{dni}";
        }
    }
}
