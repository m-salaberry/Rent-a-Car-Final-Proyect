namespace UI
{
    partial class ABMAutos
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
            groupBox3 = new GroupBox();
            btnEliminarAuto = new Button();
            label11 = new Label();
            txtElimPatente = new TextBox();
            groupBox2 = new GroupBox();
            btnBuscarAuto = new Button();
            txtModAutoDetalles = new TextBox();
            label7 = new Label();
            txtModAutoKilometraje = new TextBox();
            label8 = new Label();
            txtModAutoPrecio = new TextBox();
            label13 = new Label();
            btnModificarAuto = new Button();
            label10 = new Label();
            txtModAutoPatente = new TextBox();
            groupBox1 = new GroupBox();
            txtCAutoDetalles = new TextBox();
            label12 = new Label();
            txtCAutoColor = new TextBox();
            label9 = new Label();
            txtCAutoKilometraje = new TextBox();
            label6 = new Label();
            txtCAutoPrecio = new TextBox();
            txtCAutoAno = new TextBox();
            label3 = new Label();
            txtCAutoModelo = new TextBox();
            btnCrearAuto = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCAutoMarca = new TextBox();
            txtCAutoPatente = new TextBox();
            dgvAllCars = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllCars).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarAuto);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtElimPatente);
            groupBox3.Location = new Point(367, 335);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 116);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Auto";
            // 
            // btnEliminarAuto
            // 
            btnEliminarAuto.Location = new Point(6, 62);
            btnEliminarAuto.Name = "btnEliminarAuto";
            btnEliminarAuto.Size = new Size(326, 43);
            btnEliminarAuto.TabIndex = 11;
            btnEliminarAuto.Text = "Eliminar Auto";
            btnEliminarAuto.UseVisualStyleBackColor = true;
            btnEliminarAuto.Click += btnEliminarAuto_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 15);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 3;
            label11.Text = "Patente";
            // 
            // txtElimPatente
            // 
            txtElimPatente.Location = new Point(6, 33);
            txtElimPatente.Name = "txtElimPatente";
            txtElimPatente.Size = new Size(326, 23);
            txtElimPatente.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarAuto);
            groupBox2.Controls.Add(txtModAutoDetalles);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtModAutoKilometraje);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtModAutoPrecio);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(btnModificarAuto);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtModAutoPatente);
            groupBox2.Location = new Point(367, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 317);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Auto";
            // 
            // btnBuscarAuto
            // 
            btnBuscarAuto.Location = new Point(6, 65);
            btnBuscarAuto.Name = "btnBuscarAuto";
            btnBuscarAuto.Size = new Size(326, 28);
            btnBuscarAuto.TabIndex = 28;
            btnBuscarAuto.Text = "Buscar Auto";
            btnBuscarAuto.UseVisualStyleBackColor = true;
            btnBuscarAuto.Click += btnBuscarAuto_Click;
            // 
            // txtModAutoDetalles
            // 
            txtModAutoDetalles.Enabled = false;
            txtModAutoDetalles.Location = new Point(6, 203);
            txtModAutoDetalles.Multiline = true;
            txtModAutoDetalles.Name = "txtModAutoDetalles";
            txtModAutoDetalles.Size = new Size(326, 76);
            txtModAutoDetalles.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 185);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 26;
            label7.Text = "Detalles";
            // 
            // txtModAutoKilometraje
            // 
            txtModAutoKilometraje.Enabled = false;
            txtModAutoKilometraje.Location = new Point(6, 159);
            txtModAutoKilometraje.Name = "txtModAutoKilometraje";
            txtModAutoKilometraje.Size = new Size(326, 23);
            txtModAutoKilometraje.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 141);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 24;
            label8.Text = "Kilometraje";
            // 
            // txtModAutoPrecio
            // 
            txtModAutoPrecio.Enabled = false;
            txtModAutoPrecio.Location = new Point(6, 115);
            txtModAutoPrecio.Name = "txtModAutoPrecio";
            txtModAutoPrecio.Size = new Size(326, 23);
            txtModAutoPrecio.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 97);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 22;
            label13.Text = "Precio por Día";
            // 
            // btnModificarAuto
            // 
            btnModificarAuto.Location = new Point(6, 283);
            btnModificarAuto.Name = "btnModificarAuto";
            btnModificarAuto.Size = new Size(326, 28);
            btnModificarAuto.TabIndex = 11;
            btnModificarAuto.Text = "Modificar Auto";
            btnModificarAuto.UseVisualStyleBackColor = true;
            btnModificarAuto.Click += btnModificarAuto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 3;
            label10.Text = "Patente";
            // 
            // txtModAutoPatente
            // 
            txtModAutoPatente.Location = new Point(6, 37);
            txtModAutoPatente.Name = "txtModAutoPatente";
            txtModAutoPatente.Size = new Size(326, 23);
            txtModAutoPatente.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCAutoDetalles);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtCAutoColor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCAutoKilometraje);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCAutoPrecio);
            groupBox1.Controls.Add(txtCAutoAno);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCAutoModelo);
            groupBox1.Controls.Add(btnCrearAuto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCAutoMarca);
            groupBox1.Controls.Add(txtCAutoPatente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 439);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Auto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCAutoDetalles
            // 
            txtCAutoDetalles.Location = new Point(6, 351);
            txtCAutoDetalles.Name = "txtCAutoDetalles";
            txtCAutoDetalles.Size = new Size(326, 23);
            txtCAutoDetalles.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 333);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 20;
            label12.Text = "Detalles";
            // 
            // txtCAutoColor
            // 
            txtCAutoColor.Location = new Point(6, 308);
            txtCAutoColor.Name = "txtCAutoColor";
            txtCAutoColor.Size = new Size(326, 23);
            txtCAutoColor.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 290);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 18;
            label9.Text = "Color";
            // 
            // txtCAutoKilometraje
            // 
            txtCAutoKilometraje.Location = new Point(6, 266);
            txtCAutoKilometraje.Name = "txtCAutoKilometraje";
            txtCAutoKilometraje.Size = new Size(326, 23);
            txtCAutoKilometraje.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 248);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 16;
            label6.Text = "Kilometraje";
            // 
            // txtCAutoPrecio
            // 
            txtCAutoPrecio.Location = new Point(6, 222);
            txtCAutoPrecio.Name = "txtCAutoPrecio";
            txtCAutoPrecio.Size = new Size(326, 23);
            txtCAutoPrecio.TabIndex = 15;
            // 
            // txtCAutoAno
            // 
            txtCAutoAno.Location = new Point(6, 178);
            txtCAutoAno.Name = "txtCAutoAno";
            txtCAutoAno.Size = new Size(326, 23);
            txtCAutoAno.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 13;
            label3.Text = "Modelo";
            // 
            // txtCAutoModelo
            // 
            txtCAutoModelo.Location = new Point(6, 134);
            txtCAutoModelo.Name = "txtCAutoModelo";
            txtCAutoModelo.Size = new Size(326, 23);
            txtCAutoModelo.TabIndex = 12;
            // 
            // btnCrearAuto
            // 
            btnCrearAuto.Location = new Point(6, 380);
            btnCrearAuto.Name = "btnCrearAuto";
            btnCrearAuto.Size = new Size(326, 48);
            btnCrearAuto.TabIndex = 11;
            btnCrearAuto.Text = "Crear Auto";
            btnCrearAuto.UseVisualStyleBackColor = true;
            btnCrearAuto.Click += btnCrearAuto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 204);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "Precio por Día";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 160);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Año del Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Patente";
            // 
            // txtCAutoMarca
            // 
            txtCAutoMarca.Location = new Point(6, 90);
            txtCAutoMarca.Name = "txtCAutoMarca";
            txtCAutoMarca.Size = new Size(326, 23);
            txtCAutoMarca.TabIndex = 1;
            // 
            // txtCAutoPatente
            // 
            txtCAutoPatente.Location = new Point(6, 46);
            txtCAutoPatente.Name = "txtCAutoPatente";
            txtCAutoPatente.Size = new Size(326, 23);
            txtCAutoPatente.TabIndex = 0;
            // 
            // dgvAllCars
            // 
            dgvAllCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllCars.Location = new Point(720, 19);
            dgvAllCars.Name = "dgvAllCars";
            dgvAllCars.Size = new Size(616, 432);
            dgvAllCars.TabIndex = 7;
            // 
            // ABMAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 463);
            Controls.Add(dgvAllCars);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ABMAutos";
            Text = "ABM Autos";
            Load += ABMAutos_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnEliminarAuto;
        private Label label11;
        private TextBox txtElimPatente;
        private GroupBox groupBox2;
        private Button btnModificarAuto;
        private Label label10;
        private TextBox txtModAutoPatente;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtCAutoModelo;
        private Button btnCrearAuto;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtCAutoMarca;
        private TextBox txtCAutoPatente;
        private TextBox txtCAutoKilometraje;
        private Label label6;
        private TextBox txtCAutoPrecio;
        private TextBox txtCAutoAno;
        private TextBox txtCAutoColor;
        private Label label9;
        private TextBox txtCAutoDetalles;
        private Label label12;
        private TextBox txtModAutoDetalles;
        private Label label7;
        private TextBox txtModAutoKilometraje;
        private Label label8;
        private TextBox txtModAutoPrecio;
        private Label label13;
        private Button btnBuscarAuto;
        private DataGridView dgvAllCars;
    }
}