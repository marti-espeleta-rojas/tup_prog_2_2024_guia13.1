using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicoEjercicio.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.VisualStyles;

namespace UnicoEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxTipo.Items.Add("1 - Auto");
            cbxTipo.Items.Add("2 - Moto");
            cbxTipo.Items.Add("3 - Equipo de trabajo");
            cbxTipo.Items.Add("4 - Bicicleta");
        }

        Agencia agencia = new Agencia();

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                agencia = bf.Deserialize(fs) as Agencia;
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(Application.StartupPath, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, agencia);
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                long dni = Convert.ToInt64(tbDNI.Text);
                string patente;
                Vehiculo vehi = null;
                Ticket ticket = null;
                if (rbDenuncia.Checked)
                {
                    patente = tbDenuncia.Text;
                    vehi = new Vehiculo(patente, null);
                    agencia.listaVehiculos.Sort();
                    int idx = agencia.listaVehiculos.BinarySearch(vehi);
                    if (idx >= 0)
                    {
                        //Agrego a la lista de espera un nuevo Ticket.
                        ticket = new Denuncia((Vehiculo)agencia[idx]);
                        agencia.AgregarTicket(ticket);
                        lbxTurnos.Items.Add(ticket);
                    }
                    else
                    {
                        //puede ser que este paso esté demás ya que el enunciado es de una aseguradora que se supone que ya tiene
                        //vehículos y sus dueños asegurados.
                        vehi = new Vehiculo(patente, new Cliente(dni));
                        agencia.listaVehiculos.Add(vehi);
                        ticket = new Denuncia(vehi);
                        agencia.AgregarTicket(ticket);
                        lbxTurnos.Items.Add(vehi + "(Nuevo vehículo asegurado)");
                    }
                }
                else
                {
                    if (rbNuevoCliente.Checked)
                    {
                        ticket = new Cliente(dni);
                        agencia.AgregarTicket(ticket);
                        lbxTurnos.Items.Add(ticket + "Nuevo Cliente");
                    }
                    else
                    {
                        MessageBox.Show("Elija el tipo de ticket por favor.");
                    }
                }
                tbDenuncia.Clear();
                tbDNI.Clear();
                rbDenuncia.Checked = false;
                rbNuevoCliente.Checked = false;
            }
            catch (DNINoValidoException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch(IndexOutOfRangeException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (InvalidCastException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = null;
                ticket = agencia.AntenderTicket(0);
                if (ticket != null)
                {
                    lbxTurnos.Items.Remove(ticket);
                }
            }
            //Excepción del método Remove de ListBox.
            catch (ArgumentOutOfRangeException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.Message);
            }
        }

        private void btnAtenderClientes_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = null;
                ticket = agencia.AntenderTicket(1);
                if(ticket != null)
                {
                    lbxTurnos.Items.Remove(ticket);
                }
            }
            //Excepción del método remove de ListBox.
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarVehiculos_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            FileStream fs = null;
            StreamReader sr = null;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] lines = linea.Split(';');
                        string patente = lines[0];
                        int dni = Convert.ToInt32(lines[1]);
                        agencia.AgregarVehiculo(patente, dni);
                    }
                }
                catch (FormatException fw)
                {
                    MessageBox.Show(fw.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ez)
                {
                    MessageBox.Show(ez.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
