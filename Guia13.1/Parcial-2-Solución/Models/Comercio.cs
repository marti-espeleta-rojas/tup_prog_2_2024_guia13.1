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
        List<CuentaCorriente> cuentas = new List<CuentaCorriente>() 
        //Inicializo las cuentas del comercio
        { new CuentaCorriente(1, new Cliente(47175513)), new CuentaCorriente(2, new Cliente(24264435)), new CuentaCorriente(4, new Cliente(34523667)), new CuentaCorriente(3, new Cliente(24665743))};
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
