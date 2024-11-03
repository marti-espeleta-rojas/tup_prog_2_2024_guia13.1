using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();
        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();
        public List<Vehiculo> listaVehiculos { get; set; } = new List<Vehiculo>() { new Vehiculo("MGR321", null), new Vehiculo("XDA251", null), new Vehiculo("ONR482", null), new Vehiculo("ESP123", null)};
        public Vehiculo this[int idx]
        {
            get
            {
                if (listaVehiculos.Count >= 0)
                {
                    return listaVehiculos[idx];
                }
                else
                {
                    throw new IndexOutOfRangeException("No existen vehículos. Por favor, ingrese un vehículo para registrar el ticket");
                }
            }
        }
        public void AgregarTicket(Ticket turno)
        {
            if(turno is Cliente)
            {
                nuevosClientes.Enqueue((Cliente)turno);
            }
            else
            {
                denuncias.Enqueue((Denuncia)turno);
            }
        }

        public Ticket AntenderTicket(int tipo)
        {
            Ticket ticket = null;
            if (tipo == 0)
            {
                ticket = denuncias.Peek();
                ListaAtendidos.Add(denuncias.Dequeue());
            }
            else
            {
                if(tipo == 1)
                {
                    ticket = nuevosClientes.Peek();
                    ListaAtendidos.Add(nuevosClientes.Dequeue());
                }
            }
            return ticket;
        }
    }
}
