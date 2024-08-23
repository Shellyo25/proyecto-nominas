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
        int tipoUsuario;
        public MENU()
        {
            InitializeComponent();
            txtNombre.Text = Usuarios.nombre;
            tipoUsuario = Usuarios.id_tipo;
            if (tipoUsuario == 1)
            {
                this.btEmpleados.Visible = true;
                this.btUsuarios.Visible = true;
                this.btPlanilla.Visible = true;
                this.btnHoras.Visible = true;
                this.btnDeducciones.Visible = true;
                this.btnPermisos.Visible = true;
                this.btnRoles.Visible = true;

            }
            else
            {
                this.btEmpleados.Visible = false;
                this.btUsuarios.Visible = false;
                this.btPlanilla.Visible = false;
                this.btnHoras.Visible = false;
                this.btnDeducciones.Visible = false;
                this.btnPermisos.Visible = false;
                this.btnRoles.Visible = false;

            }
        }
        //Mario Martínez y Angel Ajanel
        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void MENU_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();
        }

        private void btEmpleados_Click_1(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btUsuarios_Click_1(object sender, EventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btPlanilla_Click_1(object sender, EventArgs e)
        {
            Planilla frm = new Planilla();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            Horas_trabajadas frm = new Horas_trabajadas();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btRecibo_Click_1(object sender, EventArgs e)
        {
            Recibo frm = new Recibo();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btConsultaU_Click_1(object sender, EventArgs e)
        {
            UsuarioRegistrados frm = new UsuarioRegistrados();
            frm.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanillasRegistradas frm = new PlanillasRegistradas();
            frm.Visible = true;
            this.Visible = false;

        }

        private void btConsultaE_Click(object sender, EventArgs e)
        {
            ConsultaEmpleads frm = new ConsultaEmpleads();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            Deducciones frm = new Deducciones();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            Permisos frm = new Permisos();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Rol frm = new Rol();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Visible = true;
            Usuarios r = new Usuarios();
        }
    }
}

//Shelly Ordoñez
