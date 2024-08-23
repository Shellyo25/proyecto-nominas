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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

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
        public void limpiar_tablas()
        {
            txtCodPlanilla.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSueldom.Text = "";
            txtSueldoe.Text = "";
            txtTotal_dev.Text = "";
            txtTotal_des.Text = "";
            txtSalariof.Text = "";

        }
        public void llamar_tablas()
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
            if (int.TryParse(txtcodE.Text, out int idEmpleado))
            {
                try
                {
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        string query = @"
                    SELECT Nombre_emp,Apellido_emp, SlrioMensual, SlrioExtra, TtlDvgdo, TtlDeduccion, SlrioLiquido
                    FROM Planilla 
                    WHERE ID_planilla = @IDplailla";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDplailla", idEmpleado);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtNombre.Text = reader["Nombre_emp"].ToString();
                                    txtApellido.Text = reader["Apellido_emp"].ToString();
                                    txtSueldom.Text = reader["SlrioMensual"].ToString();
                                    txtSueldom.Text = reader["SlrioExtra"].ToString();
                                    txtSueldom.Text = reader["TtlDvgdo"].ToString();
                                    txtSueldom.Text = reader["TltDeduccion"].ToString();
                                    txtSueldom.Text = reader["SlrioLiquido"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna informacion del ID proporcionado.");
                                }
                            }
                        }
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtCodPlanilla.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSueldom.Text) ||
                string.IsNullOrWhiteSpace(txtSueldoe.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_dev.Text) ||
                string.IsNullOrWhiteSpace(txtTotal_des.Text) ||
                string.IsNullOrWhiteSpace(txtSalariof.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }
            cn.Open();

            string connectionString = "SELECT * FROM Recibo WHERE ID_planilla  = @IDplanilla";
            using (MySqlCommand con = new MySqlCommand(connectionString, cn))
            {

                try
                {
                    con.Parameters.AddWithValue("@IDplanilla", txtCodPlanilla.Text);

                    string query = @"INSERT INTO Recibo (Fecha,ID_planilla, Nombre_emp, Apellido_emp, SlrioMensual, SlrioExtra, TtlDvngdo, TtlDeduccion,SlrioLiquido)
            VALUES (@Fecha, @IDplanilla, @Nombre_emp, @Apellido_emp, @SlrioMensual, @SlriExtra, @TtlDvngd,@TtlDeduccion, @SlrioLiquido)";

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        comando.Parameters.AddWithValue("@Fecha", dtFecha.Text);
                        comando.Parameters.AddWithValue("@IDEmpls", txtcodE.Text);
                        comando.Parameters.AddWithValue("@Nombre_emp", txtNombre.Text);
                        comando.Parameters.AddWithValue("@Apellido_emp", txtApellido.Text);
                        comando.Parameters.AddWithValue("@SlrioMensual", txtSueldom.Text);
                        comando.Parameters.AddWithValue("@SlriExtra", txtSueldoe.Text);
                        comando.Parameters.AddWithValue("@TtlDvngd", txtTotal_dev.Text);
                        comando.Parameters.AddWithValue("@TtlDeduccion", txtTotal_des.Text);
                        comando.Parameters.AddWithValue("@SlrioLiquido", txtSalariof.Text);

                        comando.ExecuteNonQuery();
                    }


                    llamar_tablas();
                    limpiar_tablas();
                    cn.Close();
                    MessageBox.Show("Datos registrados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }



    }
}

//Erkck Muñoz
