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
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtID.Text) ||
                string.IsNullOrWhiteSpace(TxtHrsDiarias.Text) ||
                string.IsNullOrWhiteSpace(TxtTtlDvngdo.Text) ||
                string.IsNullOrWhiteSpace(TxtHrsExtra.Text) ||
                string.IsNullOrWhiteSpace(TxtSlrioDiario.Text) ||
                string.IsNullOrWhiteSpace(TxtDiasLbrds.Text) ||
                string.IsNullOrWhiteSpace(TxtSlrioMnsual.Text) ||
                string.IsNullOrWhiteSpace(TxtSlrioExtra.Text) ||
                DTPFecha.Value == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return; // Salir del método si los campos no están completos
            }

            try
            {
                cn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Hrs_trabajadas WHERE IDEmpls = @IDEmpls";
                using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, cn))
                {
                    checkCommand.Parameters.AddWithValue("@IDEmpls", TxtID.Text);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        string updateQuery = @"
                    UPDATE Hrs_trabajadas
                    SET NombreEmpl = @NombreEmpl,
                        Fecha = @Fecha,
                        HrsDiarias = @HrsDiarias,
                        TtlDvngdo = @TtlDvngdo,
                        HrsExtra = @HrsExtra,
                        SlrioDiario = @SlrioDiario,
                        DiasLbrds = @DiasLbrds,
                        SlrioMensual = @SlrioMensual,
                        SlrioExtra = @SlrioExtra
                    WHERE IDEmpls = @IDEmpls";

                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, cn))
                        {
                            updateCommand.Parameters.AddWithValue("@NombreEmpl", TxtNombre.Text); 
                            updateCommand.Parameters.AddWithValue("@IDEmpls", TxtID.Text);
                            updateCommand.Parameters.AddWithValue("@Fecha", DTPFecha.Value.ToString("yyyy-MM-dd"));
                            updateCommand.Parameters.AddWithValue("@HrsDiarias", TxtHrsDiarias.Text);
                            updateCommand.Parameters.AddWithValue("@TtlDvngdo", TxtTtlDvngdo.Text);
                            updateCommand.Parameters.AddWithValue("@HrsExtra", TxtHrsExtra.Text);
                            updateCommand.Parameters.AddWithValue("@SlrioDiario", TxtSlrioDiario.Text);
                            updateCommand.Parameters.AddWithValue("@DiasLbrds", TxtDiasLbrds.Text);
                            updateCommand.Parameters.AddWithValue("@SlrioMensual", TxtSlrioMnsual.Text);
                            updateCommand.Parameters.AddWithValue("@SlrioExtra", TxtSlrioExtra.Text);

                            updateCommand.ExecuteNonQuery();
                            LimpiarCampos();

                        }
                    }
                    else
                    {
                        string insertQuery = @"
                    INSERT INTO Hrs_trabajadas (NombreEmpl, IDEmpls, Fecha, HrsDiarias, TtlDvngdo, HrsExtra, SlrioDiario, DiasLbrds, SlrioMensual, SlrioExtra)
                    VALUES (@NombreEmpl, @IDEmpls, @Fecha, @HrsDiarias, @TtlDvngdo, @HrsExtra, @SlrioDiario, @DiasLbrds, @SlrioMensual, @SlrioExtra)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, cn))
                        {
                            insertCommand.Parameters.AddWithValue("@NombreEmpl", TxtNombre.Text);
                            insertCommand.Parameters.AddWithValue("@IDEmpls", TxtID.Text);
                            insertCommand.Parameters.AddWithValue("@Fecha", DTPFecha.Value.ToString("yyyy-MM-dd"));
                            insertCommand.Parameters.AddWithValue("@HrsDiarias", TxtHrsDiarias.Text);
                            insertCommand.Parameters.AddWithValue("@TtlDvngdo", TxtTtlDvngdo.Text);
                            insertCommand.Parameters.AddWithValue("@HrsExtra", TxtHrsExtra.Text);
                            insertCommand.Parameters.AddWithValue("@SlrioDiario", TxtSlrioDiario.Text);
                            insertCommand.Parameters.AddWithValue("@DiasLbrds", TxtDiasLbrds.Text);
                            insertCommand.Parameters.AddWithValue("@SlrioMensual", TxtSlrioMnsual.Text);
                            insertCommand.Parameters.AddWithValue("@SlrioExtra", TxtSlrioExtra.Text);

                            insertCommand.ExecuteNonQuery();
                            LimpiarCampos();
                        }
                    }
                }

                cn.Close();

                MessageBox.Show("¡DATOS GUARDADOS CORRECTAMENTE!");

                LimpiarCampos();
                llamar_tablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtID.Text = "";
            DTPFecha.Text = "";
            TxtHrsDiarias.Text = "";
            TxtTtlDvngdo.Text = "";
            TxtHrsExtra.Text = "";
            TxtSlrioDiario.Text = "";
            TxtDiasLbrds.Text = "";
            TxtSlrioMnsual.Text = "";
            TxtSlrioExtra.Text = "";
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
            String consulta = "SELECT * FROM Hrs_trabajadas";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(TxtID.Text, out int idEmpleado))
            {
                try
                {
                    // Verificar que la conexión esté abierta
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();

                        // Consulta para obtener la Fecha_ingreso y Salario desde la tabla empleados
                        string query = @"
                    SELECT
                        Nombre,
                        Fecha_ingreso, 
                        Salario
                    FROM empleados 
                    WHERE ID_empleado = @IDEmpls";

                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDEmpls", idEmpleado);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Asignar datos de la tabla empleados a textboxes
                                    TxtNombre.Text = reader["Nombre"].ToString();
                                    DTPFecha.Value = DateTime.Parse(reader["Fecha_ingreso"].ToString());
                                    TxtSlrioMnsual.Text = reader["Salario"].ToString();

                                    // Cargar datos de Hrs_trabajadas si existen
                                    CargarHorasTrabajadas(idEmpleado);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún empleado con el ID proporcionado.");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de empleado válido.");
            }
        }

        private void CargarHorasTrabajadas(int idEmpleado)
        {
            try
            {
                string query = @"
            SELECT 
                NombreEmpl,
                Fecha,
                HrsDiarias, 
                TtlDvngdo, 
                HrsExtra, 
                SlrioDiario, 
                DiasLbrds, 
                SlrioMensual, 
                SlrioExtra 
            FROM Hrs_trabajadas 
            WHERE IDEmpls = @IDEmpls";

                using (MySqlConnection cn = Conexion.getConexion())
                {
                    cn.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        comando.Parameters.AddWithValue("@IDEmpls", idEmpleado);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TxtNombre.Text = reader["NombreEmpl"].ToString();
                                TxtHrsDiarias.Text = reader["HrsDiarias"].ToString();
                                TxtTtlDvngdo.Text = reader["TtlDvngdo"].ToString();
                                TxtHrsExtra.Text = reader["HrsExtra"].ToString();
                                TxtSlrioDiario.Text = reader["SlrioDiario"].ToString();
                                TxtDiasLbrds.Text = reader["DiasLbrds"].ToString();
                                TxtSlrioMnsual.Text = reader["SlrioMensual"].ToString();
                                TxtSlrioExtra.Text = reader["SlrioExtra"].ToString();
                                DTPFecha.Value = DateTime.Parse(reader["Fecha"].ToString());
                            }
                            else
                            {
                                // Si no hay datos en Hrs_trabajadas, limpiar los campos relacionados
                                LimpiarCamposHoras();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCamposHoras()
        {
            TxtHrsDiarias.Text = "";
            TxtTtlDvngdo.Text = "";
            TxtHrsExtra.Text = "";
            TxtSlrioDiario.Text = "";
            TxtDiasLbrds.Text = "";
            TxtSlrioExtra.Text = "";
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text) || !int.TryParse(TxtID.Text, out int idEmpleado))
            {
                MessageBox.Show("Por favor, ingrese un ID de empleado válido.");
                return;
            }

            try
            {
                using (MySqlConnection cn = Conexion.getConexion())
                {
                    cn.Open();

                    // Verificar si el registro existe
                    string checkQuery = "SELECT COUNT(*) FROM Hrs_trabajadas WHERE IDEmpls = @IDEmpls";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, cn))
                    {
                        checkCommand.Parameters.AddWithValue("@IDEmpls", idEmpleado);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // Eliminar el registro
                            string deleteQuery = "DELETE FROM Hrs_trabajadas WHERE IDEmpls = @IDEmpls";
                            using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, cn))
                            {
                                deleteCommand.Parameters.AddWithValue("@IDEmpls", idEmpleado);
                                deleteCommand.ExecuteNonQuery();

                                MessageBox.Show("¡Registro eliminado correctamente!");

                                // Limpiar campos y actualizar la tabla
                                LimpiarCampos();
                                llamar_tablas();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún registro para el ID proporcionado.");
                        }
                    }
                }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            MENU frm = new MENU();
            frm.Visible = true;
            this.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void textBox9_TextChanged(object sender, EventArgs e)//hras extras
        {
            // Verifica si el texto es un número válido
            if (decimal.TryParse(TxtHrsExtra.Text, out decimal horasExtras))
            {
                // Verifica si el salario diario está calculado
                if (decimal.TryParse(TxtSlrioDiario.Text, out decimal salarioDiario))
                {
                    decimal hraextra = salarioDiario / 8;
                    decimal salarioExtra = horasExtras * (hraextra * 1.5m);
                    TxtSlrioExtra.Text = salarioExtra.ToString("F2");

                    // Recalcular el salario total
                    CalcularSalarioTotal();
                } //horasExtras * (salarioDiario * 1.5m
            }
            else
            {
                TxtSlrioExtra.Text = "0.00";
            }
        }

        private void CalcularSalarioTotal()
        {
            // Verifica si el salario mensual y el salario extra están calculados
            if (decimal.TryParse(TxtSlrioMnsual.Text, out decimal salarioMensual) &&
                decimal.TryParse(TxtSlrioExtra.Text, out decimal salarioExtra))
            {
                // Calcular el salario total
                decimal salarioTotal = salarioMensual + salarioExtra;
                TxtTtlDvngdo.Text = salarioTotal.ToString("F2");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)//total devengado
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//sueld mensual
        {
            if (decimal.TryParse(TxtSlrioMnsual.Text, out decimal salarioMensual))
            {
                if (decimal.TryParse(TxtDiasLbrds.Text, out decimal DiasLab))
                {
                    // Calcular el salario diario

                    decimal salarioDiario = salarioMensual / DiasLab; // Suponiendo 30 días en un mes
                    TxtSlrioDiario.Text = salarioDiario.ToString("F2");

                    // Recalcular el salario total
                    CalcularSalarioTotal();
                }
            }
            else
            {
                TxtSlrioDiario.Text = "0.00";
            }

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)//salario diario
        {
            // Verifica si el texto es un número válido
            if (decimal.TryParse(TxtSlrioMnsual.Text, out decimal salarioMensual))
            {
                if (decimal.TryParse(TxtDiasLbrds.Text, out decimal DiasLab))
                {
                    // Calcular el salario diario

                    decimal salarioDiario = salarioMensual / DiasLab; // Suponiendo 30 días en un mes
                    TxtSlrioDiario.Text = salarioDiario.ToString("F2");

                    // Recalcular el salario total
                    CalcularSalarioTotal();
                }
            }
            else
            {
                TxtSlrioDiario.Text = "0.00";
            }
        }

        private void TxtSlrioExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDiasLbrds_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtSlrioMnsual.Text, out decimal salarioMensual))
            {
                if (decimal.TryParse(TxtDiasLbrds.Text, out decimal DiasLab))
                {
                    // Calcular el salario diario

                    decimal salarioDiario = salarioMensual / DiasLab; // Suponiendo 30 días en un mes
                    TxtSlrioDiario.Text = salarioDiario.ToString("F2");

                    // Recalcular el salario total
                    CalcularSalarioTotal();
                }
            }
            else
            {
                TxtSlrioDiario.Text = "0.00";
            }
        }
    }
}
