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
using static Warehouse.jsonporcentajes;

namespace Warehouse
{
    public partial class porcentajes : Form
    {
        public porcentajes()
        {
            InitializeComponent();
            carga();
        }

        private void btnagrega_Click(object sender, EventArgs e)
        {

            try
            {
                //? es asignale
                string id = txt1.Text;
                string porcentaje = txt2.Text;
                string palcien = txt3.Text;
                Uri u = new Uri("https://fireless-tasks.000webhostapp.com/warehouse/insertapor.php?id=" + id + "&porcentaje=" + porcentaje + "&palcien=" + palcien);
                string datos = new WebClient().DownloadString(u);
                MessageBox.Show("Agregado");
                carga();

            }
            catch (Exception x)
            {

            }
        }

        private void carga()
        {
            string json = new WebClient().DownloadString("https://fireless-tasks.000webhostapp.com/warehouse/porcentajes.php");
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<based> lista = js.Deserialize<List<based>>(json);
            respuesta mirar = new respuesta();
            mirar.registro = lista;
            if (lblaid.Text == "")
            {
                for (int i = 0; i < lista.Count; i++)
                {

                    lblaid.Text = lblaid.Text + "\n" + mirar.registro[i].id;
                    lblporcen.Text = lblporcen.Text + "\n" + mirar.registro[i].porcentajeventas;
                    lblporcien.Text = lblporcien.Text + "\n" + mirar.registro[i].porcentajepara100;

                }
            }
            else
            {
                lblaid.Text = "";
                lblporcen.Text = "";
                lblporcien.Text = "";
                for (int i = 0; i < lista.Count; i++)
                {

                    lblaid.Text = lblaid.Text + "\n" + mirar.registro[i].id;
                    lblporcen.Text = lblporcen.Text + "\n" + mirar.registro[i].porcentajeventas;
                    lblporcien.Text = lblporcien.Text + "\n" + mirar.registro[i].porcentajepara100;

                }
            }
        }
    }
}
