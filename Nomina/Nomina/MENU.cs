using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btPlanilla_Click(object sender, EventArgs e)
        {
            Planilla frm = new Planilla();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btConsultaU_Click(object sender, EventArgs e)
        {
            UsuarioRegistrados frm = new UsuarioRegistrados();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btConsultaE_Click(object sender, EventArgs e)
        {
            ConsultaEmpleads frm = new ConsultaEmpleads();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btRecibo_Click(object sender, EventArgs e)
        {
            UsuarioRegistrados frm = new UsuarioRegistrados();
            frm.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Horas_trabajadas frm = new Horas_trabajadas();
            frm.Visible = true;
            this.Visible = false;
      
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }
    }
}

//Shelly Ordoñez
