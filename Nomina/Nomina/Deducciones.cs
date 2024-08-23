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
    public partial class Deducciones : Form
    {
        public Deducciones()
        {
            InitializeComponent();
        }
        MySqlConnection cn = Conexion.getConexion();

        private void btGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtIdHora.Text) ||
                string.IsNullOrWhiteSpace(txtTotalDvg.Text) ||
                string.IsNullOrWhiteSpace(TxtIGSS.Text) ||
                string.IsNullOrWhiteSpace(txtAnticipo.Text) ||
                string.IsNullOrWhiteSpace(TxtISR.Text) ||
                string.IsNullOrWhiteSpace(TxtTtldeduc.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }
            cn.Open();

            string connectionString = "SELECT * FROM Deducciones WHERE IDHrs = @IDHrs";
            using (MySqlCommand con = new MySqlCommand(connectionString, cn))
            {
                
                try
                {
                    con.Parameters.AddWithValue("@IDHrs", txtIdHora.Text);
                    
                    string query = @"INSERT INTO Deducciones (IDHrs, Total_devengado, IGSS, Anticipos, ISR, Total_deducciones)
                                   VALUES (@IDHrs, @Total_devengado, @IGSS, @Anticipos, @ISR, @Total_deducciones)";

                    using (MySqlCommand comando = new MySqlCommand(query, cn))
                    {
                        comando.Parameters.AddWithValue("@IDHrs", txtIdHora.Text);
                        comando.Parameters.AddWithValue("@Total_devengado", txtTotalDvg.Text);
                        comando.Parameters.AddWithValue("@IGSS", TxtIGSS.Text);
                        comando.Parameters.AddWithValue("@Anticipos", txtAnticipo.Text);
                        comando.Parameters.AddWithValue("@ISR", TxtISR.Text);
                        comando.Parameters.AddWithValue("@Total_deducciones", TxtTtldeduc.Text);

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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            cn.Open();
            string id = txtTotalDvg.Text;
            string query = ("Delete from deducciones where IDHrs = " + txtTotalDvg.Text);
            MySqlCommand cmd = new MySqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Dato eliminado correctamente");
            llamar_tablas();
            limpiar_tablas();
            cn.Close();

        }

        public void limpiar_tablas()
        {
            
            txtIdHora.Text = "";
            txtTotalDvg .Text = "";
            TxtIGSS.Text = "";
            TxtISR.Text = "";
            txtAnticipo.Text = "";
            TxtTtldeduc.Text = "";
            
        }
        public void llamar_tablas()
        {
            String consulta = "select * from deducciones";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

        }

        private void Deducciones_Load(object sender, EventArgs e)
        {
            String consulta = "select * from deducciones";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdHora.Text, out int IDHrs))
            {
                try
                {
                    // Verificar que la conexión esté abierta
                    using (MySqlConnection cn = Conexion.getConexion())
                    {
                        cn.Open();
                     string query = @"
                    SELECT
                       TtlDvngdo
                    FROM Hrs_trabajadas 
                    WHERE IDHrs = @IDHoras";
                        using (MySqlCommand comando = new MySqlCommand(query, cn))
                        {
                            comando.Parameters.AddWithValue("@IDHoras", IDHrs);

                            using (MySqlDataReader reader = comando.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Asignar datos de la tabla empleados a textboxes
                                    txtTotalDvg.Text = reader["TtlDvngdo"].ToString();
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
                MessageBox.Show("Por favor, ingrese un ID del calculo de salario válido.");
            }
        }

        private void TxtIGSS_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalDvg.Text, out decimal TtlDev))
            {
                

                double IGSS = Convert.ToDouble(TtlDev) * (4.83 / 100);
                TxtIGSS.Text = IGSS.ToString("F2");
                CalcularSalarioTotal();
            }
            else
            {
                TxtIGSS.Text = "0.00";
            }
        }


        private void txtTotalDvg_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtTotalDvg.Text, out double TtlDev))
            {

                //CALCULO IGSS
                double IGSS = Convert.ToDouble(TtlDev) * (4.83 / 100);
                TxtIGSS.Text = IGSS.ToString("F2");

                //CALCULO ISR
                double ttv = Convert.ToDouble(TtlDev) * 14;
                double boni = 250 * 12;
                double rentasex = Convert.ToDouble(TtlDev) * 2;
                double descuentos = 48000 + (IGSS * 12);
                double suma1 = (ttv + boni) - rentasex;
                double suma2 = suma1 - descuentos;
                double ISRanual = suma2 * 0.05;
                double ISRmensual = ISRanual / 12;
                TxtISR.Text = ISRmensual.ToString("F2");
                CalcularSalarioTotal();
            }
            else
            {
                TxtIGSS.Text = "0.00";
            }
           
        }

        private void TxtISR_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalDvg.Text, out decimal TtlDev))
            {


                double IGSS = Convert.ToDouble(TtlDev) * (4.83 / 100);
                TxtIGSS.Text = IGSS.ToString("F2");

                double ttv = Convert.ToDouble(TtlDev) * 14;
                double boni = 250 * 12;
                double rentasex = Convert.ToDouble(TtlDev) * 2;
                double descuentos = 48000 + (IGSS * 12);
                double suma1 = (ttv + boni)-rentasex;
                double suma2 = suma1 - descuentos;
                double ISRanual = suma2 * 0.05;
                double ISRmensual = ISRanual / 12;
                TxtISR.Text = ISRmensual.ToString("F2");
                CalcularSalarioTotal();


            }
            else
            {
                TxtIGSS.Text = "0.00";
            }
        }

        private void TxtTtldeduc_TextChanged(object sender, EventArgs e)
        {
        }
        private void CalcularSalarioTotal()
        {
            if (decimal.TryParse(TxtIGSS.Text, out decimal IGSS) &&
                 decimal.TryParse(TxtISR.Text, out decimal ISRmensual) &&
                 decimal.TryParse(txtAnticipo.Text, out decimal anticipo))
            {
                decimal decucciones = IGSS + ISRmensual + anticipo ;
                TxtTtldeduc.Text = decucciones.ToString("F2");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdHora.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtTotalDvg.Text = dataGridView1.SelectedCells[1].Value.ToString();
            TxtIGSS.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtAnticipo.Text = dataGridView1.SelectedCells[3].Value.ToString();
            TxtISR.Text = dataGridView1.SelectedCells[4].Value.ToString();
            TxtTtldeduc.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
    }
}