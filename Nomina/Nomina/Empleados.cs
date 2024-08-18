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
    public partial class Empleados : Form
    {
        
        public Empleados()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();

        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCod.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepto.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtPuesto.Text) ||
                cbbSexo.SelectedItem == null ||
                dtFecha.Value == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            try
            {
                cn.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = cn;
                comando.CommandText = ("insert into empleados(Nombre,Apellido,Sexo,Telefono,Direccion,Email,Departamento,Fecha_ingreso,Salario,Puesto_trabajo) " +
                    "values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + cbbSexo.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "'" +
                    ",'" + txtEmail.Text + "','" + txtDepto.Text + "','" + dtFecha.Text + "','" + txtSalario.Text + "','" + txtPuesto.Text + "');");
                comando.ExecuteNonQuery();
                
                cn.Close();
            }
            catch (Exception)
            {


                MessageBox.Show("r.Message+r.StackTrace");
            }
            MessageBox.Show("¡DATOS REGISTRADOS CORRECTAMENTE!");
            llamar_tablas();
            limpiar_tablas();

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consulta = "update empleados set Telefono=" + txtTelefono.Text + "', Direccion'" + txtDireccion.Text + "'" +
                    "', Departamento'" + txtDepto.Text + "', Salario'" + txtSalario.Text + "',Puesto_trabajo'" + txtPuesto.Text + " where ID_empleado="+txtCod.Text+"";
                MySqlCommand comando = new MySqlCommand(consulta,cn);
            MessageBox.Show("¡DATOS MODIFICADOS CORRECTAMENTE!");
            llamar_tablas();
            limpiar_tablas();
                cn.Close();

            }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string id = txtCod.Text;
            String query = ("delete from empleados where ID_empleado = " + txtCod.Text);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dato eliminado correctamente");
            llamar_tablas();
            limpiar_tablas();
            cn.Close();
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void limpiar_tablas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbbSexo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtDepto.Text = "";
            dtFecha.Text = "";
            txtSalario.Text = "";
            txtPuesto.Text = "";
        }
        public void llamar_tablas()
        {
            String consulta = "select * from empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            String consulta = "select * from empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void MENU_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void empleadosBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtCod.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtApellido.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cbbSexo.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtDireccion.Text = dataGridView1.SelectedCells[5].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtDepto.Text = dataGridView1.SelectedCells[7].Value.ToString();
            dtFecha.Text = dataGridView1.SelectedCells[8].Value.ToString();
            txtSalario.Text = dataGridView1.SelectedCells[9].Value.ToString();
            txtPuesto.Text = dataGridView1.SelectedCells[10].Value.ToString();

        }
    }
    
        
}

//Shelly Ordoñez