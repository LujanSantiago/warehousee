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
    public partial class Form1 : Form
    {
        public static String Uru = "https://fireless-tasks.000webhostapp.com/warehouse/login.php";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;//SOLO SI ES HTTPS
            Uri ur = new Uri(Uru + "?usua=" + txtuser.Text);
            string datos = new WebClient().DownloadString(ur);
            if (datos != "id no coincide")
            {
                string[] datos_individual = datos.Split(',');

                int con = Convert.ToInt32(datos_individual[0]);
                int c = 1;
                for (int i = 1; i <= con; i++)
                {
                    if (datos_individual[c].TrimEnd(',') == txtcontra.Text)
                    {
                        warehouse v2 = new warehouse();
                        this.Hide();
                        v2.Show();
                    }
                }
            }
            else if (datos == "Error")
            {
                MessageBox.Show("No hay datos");
            }
            else
            {
                MessageBox.Show("ID erronea");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
