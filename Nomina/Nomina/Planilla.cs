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
using System.Web;
using MySql.Data;

namespace Nomina
{
    public partial class Planilla : Form
    {
        public Planilla()
        {
            InitializeComponent();

        }

        MySqlConnection cn = Conexion.getConexion();

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            

        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            
        }
        

        private void txtBoni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDiasLab_TextChanged(object sender, EventArgs e)
        {
            

        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Planilla_Load(object sender, EventArgs e)
        {
                String consulta = "SELECT * FROM Planilla";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void MENU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void txtTotal_dev_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTotal_des_TextChanged(object sender, EventArgs e)
        {
           // CalcularSalarioTotal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtPuesto.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtSueldom.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtId_salarios.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtDiasLab.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtSueldoe.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtTotal_dev.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txtIdDeduc.Text = dataGridView1.SelectedCells[8].Value.ToString();
            txtTotal_des.Text = dataGridView1.SelectedCells[9].Value.ToString();
            txtBoni.Text = dataGridView1.SelectedCells[10].Value.ToString();
            txtSalariof.Text = dataGridView1.SelectedCells[11].Value.ToString();
            txtcodE.Text = dataGridView1.SelectedCells[12].Value.ToString();
            dtFecha.Text = dataGridView1.SelectedCells[13].Value.ToString();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
