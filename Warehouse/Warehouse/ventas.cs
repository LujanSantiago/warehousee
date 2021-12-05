using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static Warehouse.jsonventas;

namespace Warehouse
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
            carga();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txt1.Text;
            string venta = txt2.Text;
            string precio = txt3.Text;
            Uri u = new Uri("https://fireless-tasks.000webhostapp.com/warehouse/insertaventa.php?id=" + id + "&ventas=" + venta + "&precio=" + precio );
            string datos = new WebClient().DownloadString(u);
            MessageBox.Show("Agregado");
            carga();
            
        }

        private void ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void carga()
        {
            string json = new WebClient().DownloadString("https://fireless-tasks.000webhostapp.com/warehouse/ventas.php");
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<based> lista = js.Deserialize<List<based>>(json);
            respuesta mirar = new respuesta();
            mirar.registro = lista;
            if (lblid.Text == "")
            {
                for (int i = 0; i < lista.Count; i++)
                {

                    lblid.Text = lblid.Text + "\n" + mirar.registro[i].id;
                    lblventa.Text = lblventa.Text + "\n" + mirar.registro[i].ventas;
                    lblprecio.Text = lblprecio.Text + "\n" + mirar.registro[i].precio;

                }
            }
            else
            {
                lblid.Text = "";
                lblprecio.Text = "";
                lblventa.Text = "";
                for (int i = 0; i < lista.Count; i++)
                {

                    lblid.Text = lblid.Text + "\n" + mirar.registro[i].id;
                    lblventa.Text = lblventa.Text + "\n" + mirar.registro[i].ventas;
                    lblprecio.Text = lblprecio.Text + "\n" + mirar.registro[i].precio;

                }
            }
        }
    }
}
