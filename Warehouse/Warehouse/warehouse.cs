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
using static Warehouse.json;

namespace Warehouse
{
    public partial class warehouse : Form
    {
        public warehouse()
        {
            InitializeComponent();
            string json = new WebClient().DownloadString("https://fireless-tasks.000webhostapp.com/warehouse/datos.php");
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<based> lista = js.Deserialize<List<based>>(json);
            respuesta mirar = new respuesta();
            mirar.registro = lista;
            for (int i = 0; i < lista.Count; i++)
            {

                lblid.Text = lblid.Text + "\n" + mirar.registro[i].id ;
                lblname.Text = lblname.Text + "\n" + mirar.registro[i].nombre;
                lblcant.Text = lblcant.Text + "\n" + mirar.registro[i].cantidad;
                lblprice.Text = lblprice.Text + "\n" + mirar.registro[i].precio;
                lbldesc.Text = lbldesc.Text + "\n" + mirar.registro[i].descripcion;
            }

        }
        

        private void label1_Click(object sender, EventArgs e)
        {
               
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblcant_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void lbldesc_Click(object sender, EventArgs e)
        {

        }
        private void menos_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void cierre(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void warehouse_Load(object sender, EventArgs e)
        {

        }

        private void warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            agrega ag = new agrega();
            ag.Show();
        }

        private void btnactualiza_Click(object sender, EventArgs e)
        {
            ventas ven = new ventas();
            ven.Show();
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            porcentajes por = new porcentajes();
            por.Show();
        }
    }
}
