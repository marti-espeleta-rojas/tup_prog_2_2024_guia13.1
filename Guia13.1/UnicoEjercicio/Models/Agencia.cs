using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicoEjercicio.Models
{
    [Serializable]
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();
        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();
        public List<Vehiculo> listaVehiculos { get; set; } = new List<Vehiculo>() { new Vehiculo("MGR321", new Cliente(47175513)), new Vehiculo("XDA251", new Cliente(24264435)), new Vehiculo("ONR482", new Cliente(34564324)), new Vehiculo("ESP123", new Cliente(54634123))};
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

        public Vehiculo this[string pat]
        {
            get
            {
                foreach(Vehiculo v in listaVehiculos)
                {
                    if (v.VerPatente() == pat)
                    {
                        return v;
                    }
                }
                return null;
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
                if (denuncias.Count > 0)
                {
                    ticket = denuncias.Dequeue();
                }
            }
            else
            {
                if(tipo == 1)
                {
                    if(nuevosClientes.Count > 0)
                    {
                        ticket = nuevosClientes.Dequeue();
                    }
                }
            }
            if (ticket != null)
            {
                ListaAtendidos.Add(ticket);
            }
            return ticket;
        }

        public void AgregarVehiculo(string nroPat, int dni)
        {
            Vehiculo nuevo = this[nroPat];
            if (nuevo == null)
            {
                Cliente cli = new Cliente(Convert.ToInt64(nroPat));
                nuevo = new Vehiculo(nroPat, cli);
                listaVehiculos.Add(nuevo);
            }
        }

        //Método para devolver vehículos a partir de clientes
        public Vehiculo BuscarVehiPorCliente(Cliente cli)
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.VerDueño()==cli)
                {
                    return v;
                }
            }
            return null;
        }
    }
}
