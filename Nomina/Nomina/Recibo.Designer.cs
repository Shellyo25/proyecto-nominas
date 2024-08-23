
namespace Nomina
{
    partial class Recibo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcodE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalariof = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal_dev = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtSueldoe = new System.Windows.Forms.TextBox();
            this.txtSueldom = new System.Windows.Forms.TextBox();
            this.txtCodPlanilla = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal_des = new System.Windows.Forms.TextBox();
            this.MENU = new System.Windows.Forms.LinkLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 195);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtcodE
            // 
            this.txtcodE.Location = new System.Drawing.Point(894, 342);
            this.txtcodE.Name = "txtcodE";
            this.txtcodE.Size = new System.Drawing.Size(133, 22);
            this.txtcodE.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(756, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 101;
            this.label10.Text = "Codigo Empleado:";
            // 
            // txtSalariof
            // 
            this.txtSalariof.Location = new System.Drawing.Point(764, 285);
            this.txtSalariof.Name = "txtSalariof";
            this.txtSalariof.Size = new System.Drawing.Size(295, 22);
            this.txtSalariof.TabIndex = 99;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(636, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 17);
            this.label16.TabIndex = 98;
            this.label16.Text = "Sueldo a Recibir:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(241, 116);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(294, 22);
            this.dtFecha.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 96;
            this.label9.Text = "Fecha ingreso:";
            // 
            // txtTotal_dev
            // 
            this.txtTotal_dev.Location = new System.Drawing.Point(764, 184);
            this.txtTotal_dev.Name = "txtTotal_dev";
            this.txtTotal_dev.Size = new System.Drawing.Size(185, 22);
            this.txtTotal_dev.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(628, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 93;
            this.label14.Text = "Total Devengado:";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Green;
            this.btGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(1168, 87);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(147, 52);
            this.btGuardar.TabIndex = 88;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtSueldoe
            // 
            this.txtSueldoe.Location = new System.Drawing.Point(764, 146);
            this.txtSueldoe.Name = "txtSueldoe";
            this.txtSueldoe.Size = new System.Drawing.Size(185, 22);
            this.txtSueldoe.TabIndex = 84;
            // 
            // txtSueldom
            // 
            this.txtSueldom.Location = new System.Drawing.Point(764, 108);
            this.txtSueldom.Name = "txtSueldom";
            this.txtSueldom.Size = new System.Drawing.Size(185, 22);
            this.txtSueldom.TabIndex = 83;
            // 
            // txtCodPlanilla
            // 
            this.txtCodPlanilla.Location = new System.Drawing.Point(240, 195);
            this.txtCodPlanilla.Name = "txtCodPlanilla";
            this.txtCodPlanilla.Size = new System.Drawing.Size(134, 22);
            this.txtCodPlanilla.TabIndex = 81;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(240, 154);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(134, 22);
            this.txtCod.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Salario Extra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Sueldo Mensual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Codigo Planilla:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "Codigo Recibo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "RECIBO DEL PAGO DE SUELDO  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 77;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(631, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 95;
            this.label15.Text = "Total  Descuentos:";
            // 
            // txtTotal_des
            // 
            this.txtTotal_des.Location = new System.Drawing.Point(764, 241);
            this.txtTotal_des.Name = "txtTotal_des";
            this.txtTotal_des.Size = new System.Drawing.Size(295, 22);
            this.txtTotal_des.TabIndex = 85;
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.Location = new System.Drawing.Point(1222, 41);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(48, 17);
            this.MENU.TabIndex = 105;
            this.MENU.TabStop = true;
            this.MENU.Text = "MENU";
            this.MENU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MENU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MENU_LinkClicked);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 236);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 22);
            this.txtNombre.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 108;
            this.label7.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(240, 283);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(243, 22);
            this.txtApellido.TabIndex = 109;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(380, 184);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 38);
            this.btnBuscar.TabIndex = 110;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseMnemonic = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 637);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcodE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSalariof);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotal_dev);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtTotal_des);
            this.Controls.Add(this.txtSueldoe);
            this.Controls.Add(this.txtSueldom);
            this.Controls.Add(this.txtCodPlanilla);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.Recibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcodE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalariof;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal_dev;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtSueldoe;
        private System.Windows.Forms.TextBox txtSueldom;
        private System.Windows.Forms.TextBox txtCodPlanilla;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal_des;
        private System.Windows.Forms.LinkLabel MENU;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscar;
    }
}