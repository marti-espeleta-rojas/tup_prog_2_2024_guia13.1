using Parcial_2_Solución.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Solución
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Comercio comercio = new Comercio();



        private void btnTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = null;
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                if (cbNro.Checked)
                {
                    int nroCta = Convert.ToInt32(txtCtacte.Text);
                    if (comercio[nroCta] != null)
                    {
                        ticket = new Pago(comercio[nroCta]);
                        comercio.AgregarTicket(ticket);
                        lbxTurnos.Items.Add(ticket);
                    }
                    else
                    {
                        MessageBox.Show("No existe una cuenta con el número indicado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ticket = new Cliente(dni);
                    comercio.AgregarTicket(ticket);
                    lbxTurnos.Items.Add(ticket);
                }
            }
            catch(DNINoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Error: DNI no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException ez)
            {
                MessageBox.Show(ez.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            Ticket ticket = null;
            try
            {
                if (rbCompras.Checked)
                {
                    ticket = comercio.AtenderTicket(0);
                    lbxTurnos.Items.Remove(ticket);
                    MessageBox.Show("¡Cliente atendido correctamente!", "Operación completada con éxito.", MessageBoxButtons.OK);
                }
                else
                {
                    if (rbPagos.Checked)
                    {
                        ticket = comercio.AtenderTicket(1);
                        lbxTurnos.Items.Remove(ticket);
                        MessageBox.Show("¡La compra ha sido efectuada correctamente!", "Operación completada con éxito.", MessageBoxButtons.OK);
                    }
                }
            }
            catch (InvalidOperationException dc)
            {
                MessageBox.Show(dc.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ed)
            {
                MessageBox.Show(ed.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                string fileName = "Comercio.dat";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName);
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
                bf = new BinaryFormatter();
                if (fs.Length > 0)
                {
                    comercio = bf.Deserialize(fs) as Comercio;
                }
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                if (comercio == null)
                {
                    comercio = new Comercio();
                }
                string fileName = "Datos.bin";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName);
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, comercio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            OpenFileDialog open = null;
            CuentaCorriente cuenta = null;
            try
            {
                open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(open.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine(); //Leo la línea del encabezado (supongo que tiene una cabecera).
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');
                        int nro = Convert.ToInt32(campos[0].Trim());
                        int dni = Convert.ToInt32(campos[1].Trim());
                        double saldo = Convert.ToDouble(campos[2].Trim());

                        cuenta = comercio[nro];
                        if (cuenta != null)
                        {
                            cuenta.RegistrarVenta(saldo);
                        }
                        else
                        {
                            cuenta = new CuentaCorriente(nro, new Cliente(dni));
                            cuenta.RegistrarVenta(saldo);
                            comercio.AgregarCuentaCorriente(cuenta);
                        }
                    }
                }
            }
            catch (FormatException ed)
            {
                MessageBox.Show(ed.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException ef)
            {
                MessageBox.Show(ef.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
                if (open != null) open.Dispose();
            }
        }

        private void btnExportarTickets_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            SaveFileDialog save = null;
            try
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Application.StartupPath;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string path = Path.Combine(save.FileName, "Archivo.csv");
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (Ticket t in comercio.VerAtendidos())
                    {

                        if (t is Cliente)
                        {
                            Cliente cli = t as Cliente;
                            sw.WriteLine($"Cliente;{cli.VerNro()};{cli};");
                        }
                        else
                        {
                            Pago pago = t as Pago;
                            sw.WriteLine($"Pago;{pago.VerNro()};{pago};{pago.VerCuenta()}");
                        }
                    }
                }
            }
            catch (InvalidCastException ed) //no debería ocurrir pero por las dudas lo agrego
            {
                MessageBox.Show(ed.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
