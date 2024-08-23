
namespace Nomina
{
    partial class Deducciones
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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.TxtISR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdHora = new System.Windows.Forms.TextBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.TxtIGSS = new System.Windows.Forms.TextBox();
            this.txtTotalDvg = new System.Windows.Forms.TextBox();
            this.TxtTtldeduc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(728, 156);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(147, 52);
            this.btEliminar.TabIndex = 62;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Green;
            this.btGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(728, 77);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(147, 52);
            this.btGuardar.TabIndex = 61;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // TxtISR
            // 
            this.TxtISR.Enabled = false;
            this.TxtISR.Location = new System.Drawing.Point(558, 122);
            this.TxtISR.Margin = new System.Windows.Forms.Padding(4);
            this.TxtISR.Name = "TxtISR";
            this.TxtISR.Size = new System.Drawing.Size(132, 22);
            this.TxtISR.TabIndex = 60;
            this.TxtISR.TextChanged += new System.EventHandler(this.TxtISR_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Total deducciones: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Total devengado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Anticipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "ISR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "IGSS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "DEDUCCIONES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Codigo las Horas:";
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.Location = new System.Drawing.Point(766, 43);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(48, 17);
            this.MENU.TabIndex = 69;
            this.MENU.TabStop = true;
            this.MENU.Text = "MENU";
            this.MENU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MENU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MENU_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(297, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 70;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdHora
            // 
            this.txtIdHora.Location = new System.Drawing.Point(147, 75);
            this.txtIdHora.Name = "txtIdHora";
            this.txtIdHora.Size = new System.Drawing.Size(132, 22);
            this.txtIdHora.TabIndex = 71;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(558, 77);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(138, 22);
            this.txtAnticipo.TabIndex = 72;
            // 
            // TxtIGSS
            // 
            this.TxtIGSS.Location = new System.Drawing.Point(147, 173);
            this.TxtIGSS.Name = "TxtIGSS";
            this.TxtIGSS.ReadOnly = true;
            this.TxtIGSS.Size = new System.Drawing.Size(132, 22);
            this.TxtIGSS.TabIndex = 73;
            this.TxtIGSS.TextChanged += new System.EventHandler(this.TxtIGSS_TextChanged);
            // 
            // txtTotalDvg
            // 
            this.txtTotalDvg.Location = new System.Drawing.Point(147, 127);
            this.txtTotalDvg.Name = "txtTotalDvg";
            this.txtTotalDvg.Size = new System.Drawing.Size(132, 22);
            this.txtTotalDvg.TabIndex = 74;
            this.txtTotalDvg.TextChanged += new System.EventHandler(this.txtTotalDvg_TextChanged);
            // 
            // TxtTtldeduc
            // 
            this.TxtTtldeduc.Location = new System.Drawing.Point(558, 171);
            this.TxtTtldeduc.Name = "TxtTtldeduc";
            this.TxtTtldeduc.Size = new System.Drawing.Size(132, 22);
            this.TxtTtldeduc.TabIndex = 76;
            this.TxtTtldeduc.TextChanged += new System.EventHandler(this.TxtTtldeduc_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(818, 150);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 476);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtTtldeduc);
            this.Controls.Add(this.txtTotalDvg);
            this.Controls.Add(this.TxtIGSS);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.txtIdHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.TxtISR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deducciones";
            this.Text = "Deducciones";
            this.Load += new System.EventHandler(this.Deducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox TxtISR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel MENU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdHora;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.TextBox TxtIGSS;
        private System.Windows.Forms.TextBox txtTotalDvg;
        private System.Windows.Forms.TextBox TxtTtldeduc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}