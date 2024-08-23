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
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();
        private void MENU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            String consulta = "select * from deducciones";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPlanilla.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtSueldom.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtSueldoe.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtTotal_dev.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtTotal_des.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtSalariof.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtcodE.Text = dataGridView1.SelectedCells[7].Value.ToString();
            dtFecha.Text = dataGridView1.SelectedCells[8].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}

//Erkck Muñoz
