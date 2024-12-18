﻿namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCrearAlquiler = new Button();
            cmbCrearSeguro = new ComboBox();
            label5 = new Label();
            dtCrearFinAlq = new DateTimePicker();
            label4 = new Label();
            dtNuevoInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNuevoPatente = new TextBox();
            txtNuevoDNI = new TextBox();
            dgvAlquileres = new DataGridView();
            groupBox2 = new GroupBox();
            btnModificarAlquiler = new Button();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label9 = new Label();
            txtModificarId = new TextBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            txtDniCancelar = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            btnABMSeguros = new Button();
            btnABMAutos = new Button();
            btnABMClientes = new Button();
            groupBox5 = new GroupBox();
            btnClearFiltrer = new Button();
            textBox3 = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearAlquiler);
            groupBox1.Controls.Add(cmbCrearSeguro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtCrearFinAlq);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtNuevoInicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNuevoPatente);
            groupBox1.Controls.Add(txtNuevoDNI);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Alquiler";
            // 
            // btnCrearAlquiler
            // 
            btnCrearAlquiler.Location = new Point(6, 268);
            btnCrearAlquiler.Name = "btnCrearAlquiler";
            btnCrearAlquiler.Size = new Size(326, 48);
            btnCrearAlquiler.TabIndex = 11;
            btnCrearAlquiler.Text = "Confirmar Alquiler";
            btnCrearAlquiler.UseVisualStyleBackColor = true;
            btnCrearAlquiler.Click += btnCrearAlquiler_Click;
            // 
            // cmbCrearSeguro
            // 
            cmbCrearSeguro.FormattingEnabled = true;
            cmbCrearSeguro.Location = new Point(6, 225);
            cmbCrearSeguro.Name = "cmbCrearSeguro";
            cmbCrearSeguro.Size = new Size(326, 23);
            cmbCrearSeguro.TabIndex = 10;
            cmbCrearSeguro.Click += Form1_Load;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 207);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de Seguro";
            // 
            // dtCrearFinAlq
            // 
            dtCrearFinAlq.Location = new Point(6, 181);
            dtCrearFinAlq.Name = "dtCrearFinAlq";
            dtCrearFinAlq.Size = new Size(326, 23);
            dtCrearFinAlq.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha Fin Alquiler";
            // 
            // dtNuevoInicio
            // 
            dtNuevoInicio.Location = new Point(6, 134);
            dtNuevoInicio.Name = "dtNuevoInicio";
            dtNuevoInicio.Size = new Size(326, 23);
            dtNuevoInicio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha Inicio Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 4;
            label2.Text = "Patente Vehiculo a Alquilar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "DNI Cliente";
            // 
            // txtNuevoPatente
            // 
            txtNuevoPatente.Location = new Point(6, 90);
            txtNuevoPatente.Name = "txtNuevoPatente";
            txtNuevoPatente.Size = new Size(326, 23);
            txtNuevoPatente.TabIndex = 1;
            // 
            // txtNuevoDNI
            // 
            txtNuevoDNI.Location = new Point(6, 46);
            txtNuevoDNI.Name = "txtNuevoDNI";
            txtNuevoDNI.Size = new Size(326, 23);
            txtNuevoDNI.TabIndex = 0;
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(718, 12);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.Size = new Size(874, 577);
            dgvAlquileres.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModificarAlquiler);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtModificarId);
            groupBox2.Location = new Point(12, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 234);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extender Alquiler";
            // 
            // btnModificarAlquiler
            // 
            btnModificarAlquiler.Location = new Point(6, 162);
            btnModificarAlquiler.Name = "btnModificarAlquiler";
            btnModificarAlquiler.Size = new Size(326, 48);
            btnModificarAlquiler.TabIndex = 11;
            btnModificarAlquiler.Text = "Modificar Alquiler";
            btnModificarAlquiler.UseVisualStyleBackColor = true;
            btnModificarAlquiler.Click += btnModificarAlquiler_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(326, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 86);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 7;
            label7.Text = "Fecha Fin Alquiler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 24);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 4;
            label9.Text = "ID del Alquiler";
            // 
            // txtModificarId
            // 
            txtModificarId.Location = new Point(6, 42);
            txtModificarId.Name = "txtModificarId";
            txtModificarId.Size = new Size(326, 23);
            txtModificarId.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(txtDniCancelar);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(365, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 248);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cancelar Alquiler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 13;
            label6.Text = "DNI Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(6, 174);
            button1.Name = "button1";
            button1.Size = new Size(326, 48);
            button1.TabIndex = 11;
            button1.Text = "Cancelar Alquiler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDniCancelar
            // 
            txtDniCancelar.Location = new Point(6, 113);
            txtDniCancelar.Name = "txtDniCancelar";
            txtDniCancelar.Size = new Size(326, 23);
            txtDniCancelar.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 22);
            label11.Name = "label11";
            label11.Size = new Size(149, 15);
            label11.TabIndex = 4;
            label11.Text = "Patente Vehiculo Alquilado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnABMSeguros);
            groupBox4.Controls.Add(btnABMAutos);
            groupBox4.Controls.Add(btnABMClientes);
            groupBox4.Location = new Point(365, 417);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(347, 172);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Altas, Bajas y Modificaciones";
            // 
            // btnABMSeguros
            // 
            btnABMSeguros.Location = new Point(6, 120);
            btnABMSeguros.Name = "btnABMSeguros";
            btnABMSeguros.Size = new Size(335, 43);
            btnABMSeguros.TabIndex = 14;
            btnABMSeguros.Text = "ABM Seguros";
            btnABMSeguros.UseVisualStyleBackColor = true;
            btnABMSeguros.Click += btnABMSeguros_Click;
            // 
            // btnABMAutos
            // 
            btnABMAutos.Location = new Point(6, 71);
            btnABMAutos.Name = "btnABMAutos";
            btnABMAutos.Size = new Size(335, 43);
            btnABMAutos.TabIndex = 13;
            btnABMAutos.Text = "ABM Vehiculos";
            btnABMAutos.UseVisualStyleBackColor = true;
            btnABMAutos.Click += btnABMAutos_Click;
            // 
            // btnABMClientes
            // 
            btnABMClientes.Location = new Point(6, 22);
            btnABMClientes.Name = "btnABMClientes";
            btnABMClientes.Size = new Size(335, 43);
            btnABMClientes.TabIndex = 12;
            btnABMClientes.Text = "ABM Clientes";
            btnABMClientes.UseVisualStyleBackColor = true;
            btnABMClientes.Click += btnABMClientes_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnClearFiltrer);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(btnBuscar);
            groupBox5.Location = new Point(365, 266);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(347, 145);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Busqueda Alquileres";
            // 
            // btnClearFiltrer
            // 
            btnClearFiltrer.Location = new Point(174, 70);
            btnClearFiltrer.Name = "btnClearFiltrer";
            btnClearFiltrer.Size = new Size(164, 48);
            btnClearFiltrer.TabIndex = 17;
            btnClearFiltrer.Text = "Limpiar Filtro";
            btnClearFiltrer.UseVisualStyleBackColor = true;
            btnClearFiltrer.Click += btnClearFiltrer_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "PATENTE VEHICULO";
            textBox3.Size = new Size(332, 23);
            textBox3.TabIndex = 16;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 70);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(164, 48);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 600);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvAlquileres);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Rent-a-Car";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvAlquileres;
        private TextBox txtNuevoDNI;
        private TextBox txtNuevoPatente;
        private Label label2;
        private Label label1;
        private DateTimePicker dtCrearFinAlq;
        private Label label4;
        private DateTimePicker dtNuevoInicio;
        private Label label3;
        private Button btnCrearAlquiler;
        private ComboBox cmbCrearSeguro;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnModificarAlquiler;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label9;
        private TextBox txtModificarId;
        private GroupBox groupBox3;
        private Button button1;
        private Label label11;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private Button btnABMSeguros;
        private Button btnABMAutos;
        private Button btnABMClientes;
        private GroupBox groupBox5;
        private TextBox textBox3;
        private Button btnBuscar;
        private Label label6;
        private TextBox txtDniCancelar;
        private Button btnClearFiltrer;
    }
}
