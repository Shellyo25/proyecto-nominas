﻿
namespace Nomina
{
    partial class Permisos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtDescr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPFechaPerm = new System.Windows.Forms.DateTimePicker();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnMENU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Empleado";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(166, 78);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(259, 22);
            this.TxtID.TabIndex = 2;
            // 
            // TxtDescr
            // 
            this.TxtDescr.Location = new System.Drawing.Point(166, 254);
            this.TxtDescr.Multiline = true;
            this.TxtDescr.Name = "TxtDescr";
            this.TxtDescr.Size = new System.Drawing.Size(712, 126);
            this.TxtDescr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(37, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(166, 400);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 37);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(585, 78);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(259, 22);
            this.TxtNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(456, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre Empleado";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(166, 124);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(90, 37);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewPermisos
            // 
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(40, 458);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            this.dataGridViewPermisos.RowHeadersWidth = 51;
            this.dataGridViewPermisos.RowTemplate.Height = 24;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(875, 176);
            this.dataGridViewPermisos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // DTPFechaPerm
            // 
            this.DTPFechaPerm.Location = new System.Drawing.Point(166, 197);
            this.DTPFechaPerm.Name = "DTPFechaPerm";
            this.DTPFechaPerm.Size = new System.Drawing.Size(200, 22);
            this.DTPFechaPerm.TabIndex = 11;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(Nomina.Empleados);
            // 
            // BtnMENU
            // 
            this.BtnMENU.Location = new System.Drawing.Point(825, 12);
            this.BtnMENU.Name = "BtnMENU";
            this.BtnMENU.Size = new System.Drawing.Size(75, 23);
            this.BtnMENU.TabIndex = 12;
            this.BtnMENU.Text = "MENU";
            this.BtnMENU.UseVisualStyleBackColor = true;
            this.BtnMENU.Click += new System.EventHandler(this.BtnMENU_Click);
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 676);
            this.Controls.Add(this.BtnMENU);
            this.Controls.Add(this.DTPFechaPerm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtDescr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Permisos";
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtDescr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPFechaPerm;
        private System.Windows.Forms.Button BtnMENU;
    }
}