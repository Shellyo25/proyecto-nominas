
namespace Nomina
{
    partial class Horas_trabajadas
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
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtSlrioExtra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtHrsExtra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDiasLbrds = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTtlDvngdo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHrsDiarias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.LinkLabel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtSlrioMnsual = new System.Windows.Forms.TextBox();
            this.TxtSlrioDiario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(154, 205);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(186, 22);
            this.DTPFecha.TabIndex = 43;
            // 
            // TxtSlrioExtra
            // 
            this.TxtSlrioExtra.Location = new System.Drawing.Point(602, 229);
            this.TxtSlrioExtra.Name = "TxtSlrioExtra";
            this.TxtSlrioExtra.ReadOnly = true;
            this.TxtSlrioExtra.Size = new System.Drawing.Size(186, 22);
            this.TxtSlrioExtra.TabIndex = 42;
            this.TxtSlrioExtra.TextChanged += new System.EventHandler(this.TxtSlrioExtra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(497, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Salario Extra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(475, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Salario Mensual";
            // 
            // TxtHrsExtra
            // 
            this.TxtHrsExtra.Location = new System.Drawing.Point(602, 186);
            this.TxtHrsExtra.Name = "TxtHrsExtra";
            this.TxtHrsExtra.Size = new System.Drawing.Size(186, 22);
            this.TxtHrsExtra.TabIndex = 38;
            this.TxtHrsExtra.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(33, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Días laborados";
            // 
            // TxtDiasLbrds
            // 
            this.TxtDiasLbrds.Location = new System.Drawing.Point(154, 280);
            this.TxtDiasLbrds.Name = "TxtDiasLbrds";
            this.TxtDiasLbrds.Size = new System.Drawing.Size(186, 22);
            this.TxtDiasLbrds.TabIndex = 36;
            this.TxtDiasLbrds.TextChanged += new System.EventHandler(this.TxtDiasLbrds_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(503, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Salario Diario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(503, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Horas Extra";
            // 
            // TxtTtlDvngdo
            // 
            this.TxtTtlDvngdo.Location = new System.Drawing.Point(602, 277);
            this.TxtTtlDvngdo.Name = "TxtTtlDvngdo";
            this.TxtTtlDvngdo.ReadOnly = true;
            this.TxtTtlDvngdo.Size = new System.Drawing.Size(186, 22);
            this.TxtTtlDvngdo.TabIndex = 32;
            this.TxtTtlDvngdo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(481, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total devengado";
            // 
            // TxtHrsDiarias
            // 
            this.TxtHrsDiarias.Location = new System.Drawing.Point(154, 242);
            this.TxtHrsDiarias.Name = "TxtHrsDiarias";
            this.TxtHrsDiarias.Size = new System.Drawing.Size(186, 22);
            this.TxtHrsDiarias.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(33, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Horas Diarias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(33, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha de ingreso";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(152, 131);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(110, 22);
            this.TxtID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Horas trabajadas";
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.Location = new System.Drawing.Point(877, 26);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(48, 17);
            this.MENU.TabIndex = 48;
            this.MENU.TabStop = true;
            this.MENU.Text = "MENU";
            this.MENU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MENU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MENU_LinkClicked);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btSalir.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Location = new System.Drawing.Point(816, 189);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(147, 52);
            this.btSalir.TabIndex = 47;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(816, 122);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(147, 52);
            this.btEliminar.TabIndex = 46;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Green;
            this.btGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(816, 55);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(147, 52);
            this.btGuardar.TabIndex = 44;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 150);
            this.dataGridView1.TabIndex = 49;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(285, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 35);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(33, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(154, 166);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(186, 22);
            this.TxtNombre.TabIndex = 51;
            // 
            // TxtSlrioMnsual
            // 
            this.TxtSlrioMnsual.Location = new System.Drawing.Point(602, 98);
            this.TxtSlrioMnsual.Name = "TxtSlrioMnsual";
            this.TxtSlrioMnsual.ReadOnly = true;
            this.TxtSlrioMnsual.Size = new System.Drawing.Size(186, 22);
            this.TxtSlrioMnsual.TabIndex = 53;
            this.TxtSlrioMnsual.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtSlrioDiario
            // 
            this.TxtSlrioDiario.Location = new System.Drawing.Point(602, 138);
            this.TxtSlrioDiario.Name = "TxtSlrioDiario";
            this.TxtSlrioDiario.ReadOnly = true;
            this.TxtSlrioDiario.Size = new System.Drawing.Size(186, 22);
            this.TxtSlrioDiario.TabIndex = 54;
            this.TxtSlrioDiario.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // Horas_trabajadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 533);
            this.Controls.Add(this.TxtSlrioDiario);
            this.Controls.Add(this.TxtSlrioMnsual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.TxtSlrioExtra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtHrsExtra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtDiasLbrds);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTtlDvngdo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHrsDiarias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Horas_trabajadas";
            this.Text = "Horas_trabajadas";
            this.Load += new System.EventHandler(this.Horas_trabajadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.TextBox TxtSlrioExtra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtHrsExtra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtDiasLbrds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTtlDvngdo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtHrsDiarias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel MENU;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtSlrioMnsual;
        private System.Windows.Forms.TextBox TxtSlrioDiario;
    }
}