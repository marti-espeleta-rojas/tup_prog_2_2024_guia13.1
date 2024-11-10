using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2_Solución.Models
{
    [Serializable]
    public class Comercio
    {
        List<Ticket> ListaAtendidos = new List<Ticket>();
        List<CuentaCorriente> cuentas = new List<CuentaCorriente>();
        Queue<Cliente> clientes = new Queue<Cliente>();
        Queue<Pago> pagos = new Queue<Pago>();

        public CuentaCorriente this[int numero] //indexador por número de cuenta.
        {
            get
            {
                CuentaCorriente c = new CuentaCorriente(numero, null);
                cuentas.Sort();
                int idx = cuentas.BinarySearch(c);
                if(idx >= 0)
                {
                    return cuentas[idx];
                }
                else
                {
                    throw new CuentaInexistenteException();
                }
            }
        }

        public void AgregarTicket(Ticket turno)
        {
            if (turno is Cliente)
            {
                clientes.Enqueue(turno as Cliente);
            }
            else
            {
                pagos.Enqueue(turno as Pago);
            }
        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket ticket = null;
            if (tipo == 0) //Clientes
            {
                ticket = clientes.Dequeue();
            }
            else
            {
                if (tipo == 1)
                {
                    ticket = pagos.Dequeue();
                }
            }
            ListaAtendidos.Add(ticket);
            return ticket;
        }

        public void AgregarCuentaCorriente(CuentaCorriente cuenta)
        {
            cuentas.Add(cuenta);
        }

        public List<Ticket> VerAtendidos()
        {
            return ListaAtendidos;
        }
    }
}
