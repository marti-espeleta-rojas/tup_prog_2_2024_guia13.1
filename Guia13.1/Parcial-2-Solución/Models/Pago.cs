using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public class Pago : Ticket
    {
        static int nroInicio;
        CuentaCorriente ficha;

        public Pago(CuentaCorriente cuenta)
        {
            nroInicio++;
            ficha = cuenta;
            nroOrden = nroInicio;
        }

        public void MontoPago(double valor)
        {
            ficha.RegistrarPago(valor);
        }

        public CuentaCorriente VerCuenta()
        {
            return ficha;
        }

        public override string ToString()
        {
            return $"{ficha.VerTitular().ToString()}";
        }
    }
}
