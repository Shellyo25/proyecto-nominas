using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Nomina
{
    public partial class ConsultaTotalDevengado : Form
    {
        public ConsultaTotalDevengado()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();
        private void ConsultaTotalDevengado_Load(object sender, EventArgs e)
        {
            String consulta = "select * from Hrs_trabajadas";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MENU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }
    }
}
