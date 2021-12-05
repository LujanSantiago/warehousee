using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class agrega : Form
    {
        public agrega()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {

            try
            {
                //? es asignale
                string id = txt1.Text;
                string nombre = txt2.Text;
                string cantidad = txt3.Text;
                string precio = txt4.Text;
                string descripcion = txt5.Text;
                Uri u = new Uri("https://fireless-tasks.000webhostapp.com/warehouse/insercion.php?id=" + id + "&nombre=" + nombre + "&cantidad=" + cantidad + "&precio=" + precio + "&descripcion=" + descripcion);
                string datos = new WebClient().DownloadString(u);
                MessageBox.Show("Agregado");
                this.Close();

            }
            catch (Exception x)
            {
                
            }
        }

        private void agrega_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void agrega_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
