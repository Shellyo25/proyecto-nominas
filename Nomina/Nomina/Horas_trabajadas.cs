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
    public partial class Horas_trabajadas : Form
    {
        public Horas_trabajadas()
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Usuarios hrsTrbjds = new Usuarios();
            hrsTrbjds.ID = Convert.ToInt32(textBox2.Text);
            hrsTrbjds.Fecha = dateTimePicker1.Text;
            hrsTrbjds.HrsDiarias = Convert.ToInt32(textBox4.Text);
            hrsTrbjds.TtlDvngdo = Convert.ToDecimal(textBox5.Text);
            hrsTrbjds.HrsExtra = Convert.ToInt32(textBox6.Text);
            hrsTrbjds.SlrioDiario = Convert.ToDecimal(textBox10.Text);
            hrsTrbjds.DiasLbrds = Convert.ToInt32(textBox9.Text);
            hrsTrbjds.SlrioMensual = Convert.ToDecimal(textBox8.Text);
            hrsTrbjds.SlrioExtra = Convert.ToDecimal(textBox7.Text);
            
            llamar_tablas();

        }

        private void Horas_trabajadas_Load(object sender, EventArgs e)
        {
            String consulta = "select * from Hrs_trabajadas";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void llamar_tablas()
        {
            String consulta = "select * Hrs_trabajadas";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

            

        }
    }
}
