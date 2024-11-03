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

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                long dni = Convert.ToInt64(tbDNI.Text);
                string patente;
                if (rbDenuncia.Checked)
                {
                    patente = tbDenuncia.Text;
                    Vehiculo vehi = new Vehiculo(patente, null);
                    int idx = agencia.listaVehiculos.BinarySearch(vehi);
                    if (idx >= 0)
                    {
                        lbxTurnos.Items.Add((Vehiculo)agencia[idx]);
                    }
                    else
                    {
                        Vehiculo vehiculo = new Vehiculo(patente, new Cliente(dni));
                        agencia.listaVehiculos.Add(vehiculo);
                        lbxTurnos.Items.Add(vehiculo);
                    }
                }
                else
                {
                    if (rbNuevoCliente.Checked)
                    {
                        Cliente cli = new Cliente(dni);
                        lbxTurnos.Items.Add(cbxTipo.SelectedItem.ToString() + cli.ToString());
                    }
                }
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
                Ticket ticket;
                ticket = agencia.AntenderTicket(0);
                lbxTurnos.Items.Remove(ticket);
            }
            catch(NullReferenceException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (IndexOutOfRangeException ez)
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
                lbxTurnos.Items.Remove(ticket);
            }
            catch (NullReferenceException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (IndexOutOfRangeException ex)
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
            SaveFileDialog svfd = null;
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                svfd = new SaveFileDialog();
                if (svfd.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(svfd.FileName, FileMode.Create, FileAccess.Write);
                    bf = new BinaryFormatter();
                    bf.Serialize(fs, agencia);
                }
                fs.Close();
            }
            catch (ArgumentNullException ez)
            {
                MessageBox.Show(ez.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Dispose();
                svfd.Dispose();
            }
        }
    }
}
