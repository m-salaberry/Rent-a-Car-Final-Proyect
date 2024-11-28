namespace UI
{
    partial class ABMClientes
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtNClienteApellido = new TextBox();
            btnCrearAlquiler = new Button();
            label5 = new Label();
            dtNClienteVto = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNClienteNombre = new TextBox();
            txtNClienteDNI = new TextBox();
            groupBox2 = new GroupBox();
            btnModificarCliente = new Button();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtModClienteApellido = new TextBox();
            groupBox3 = new GroupBox();
            btnEliminarCliente = new Button();
            label11 = new Label();
            txtElimClienteDNI = new TextBox();
            cmbNHabilitado = new ComboBox();
            cmbModCliente = new ComboBox();
            dtModificarVto = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNHabilitado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNClienteApellido);
            groupBox1.Controls.Add(btnCrearAlquiler);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtNClienteVto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNClienteNombre);
            groupBox1.Controls.Add(txtNClienteDNI);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 309);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Apellido";
            // 
            // txtNClienteApellido
            // 
            txtNClienteApellido.Location = new Point(6, 134);
            txtNClienteApellido.Name = "txtNClienteApellido";
            txtNClienteApellido.Size = new Size(326, 23);
            txtNClienteApellido.TabIndex = 12;
            // 
            // btnCrearAlquiler
            // 
            btnCrearAlquiler.Location = new Point(6, 251);
            btnCrearAlquiler.Name = "btnCrearAlquiler";
            btnCrearAlquiler.Size = new Size(326, 48);
            btnCrearAlquiler.TabIndex = 11;
            btnCrearAlquiler.Text = "Crear Cliente";
            btnCrearAlquiler.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 204);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 9;
            label5.Text = "Habilitado";
            // 
            // dtNClienteVto
            // 
            dtNClienteVto.Location = new Point(6, 178);
            dtNClienteVto.Name = "dtNClienteVto";
            dtNClienteVto.Size = new Size(326, 23);
            dtNClienteVto.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 160);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha Vto Licencia de Conducir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
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
            // txtNClienteNombre
            // 
            txtNClienteNombre.Location = new Point(6, 90);
            txtNClienteNombre.Name = "txtNClienteNombre";
            txtNClienteNombre.Size = new Size(326, 23);
            txtNClienteNombre.TabIndex = 1;
            // 
            // txtNClienteDNI
            // 
            txtNClienteDNI.Location = new Point(6, 46);
            txtNClienteDNI.Name = "txtNClienteDNI";
            txtNClienteDNI.Size = new Size(326, 23);
            txtNClienteDNI.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtModificarVto);
            groupBox2.Controls.Add(cmbModCliente);
            groupBox2.Controls.Add(btnModificarCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtModClienteApellido);
            groupBox2.Location = new Point(367, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 201);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Cliente";
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(6, 148);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(326, 48);
            btnModificarCliente.TabIndex = 11;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 101);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 9;
            label7.Text = "Habilitado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 60);
            label8.Name = "label8";
            label8.Size = new Size(173, 15);
            label8.TabIndex = 7;
            label8.Text = "Fecha Vto Licencia de Conducir";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 3;
            label10.Text = "DNI Cliente";
            // 
            // txtModClienteApellido
            // 
            txtModClienteApellido.Location = new Point(6, 37);
            txtModClienteApellido.Name = "txtModClienteApellido";
            txtModClienteApellido.Size = new Size(326, 23);
            txtModClienteApellido.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarCliente);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtElimClienteDNI);
            groupBox3.Location = new Point(367, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(347, 102);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modificar Cliente";
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(6, 62);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(326, 30);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 15);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 3;
            label11.Text = "DNI Cliente";
            // 
            // txtElimClienteDNI
            // 
            txtElimClienteDNI.Location = new Point(6, 33);
            txtElimClienteDNI.Name = "txtElimClienteDNI";
            txtElimClienteDNI.Size = new Size(326, 23);
            txtElimClienteDNI.TabIndex = 0;
            // 
            // cmbNHabilitado
            // 
            cmbNHabilitado.FormattingEnabled = true;
            cmbNHabilitado.Location = new Point(6, 222);
            cmbNHabilitado.Name = "cmbNHabilitado";
            cmbNHabilitado.Size = new Size(326, 23);
            cmbNHabilitado.TabIndex = 14;
            // 
            // cmbModCliente
            // 
            cmbModCliente.FormattingEnabled = true;
            cmbModCliente.Location = new Point(6, 119);
            cmbModCliente.Name = "cmbModCliente";
            cmbModCliente.Size = new Size(326, 23);
            cmbModCliente.TabIndex = 15;
            // 
            // dtModificarVto
            // 
            dtModificarVto.Location = new Point(6, 78);
            dtModificarVto.Name = "dtModificarVto";
            dtModificarVto.Size = new Size(326, 23);
            dtModificarVto.TabIndex = 16;
            // 
            // ABMClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 326);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ABMClientes";
            Text = "ABM Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtNClienteApellido;
        private Button btnCrearAlquiler;
        private ComboBox cmbCrearSeguro;
        private Label label5;
        private DateTimePicker dtNClienteVto;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtNClienteNombre;
        private TextBox txtNClienteDNI;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox textBox1;
        private Button btnModificarCliente;
        private ComboBox comboBox1;
        private Label label7;
        private DateTimePicker dtModificarVto;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox txtModClienteApellido;
        private GroupBox groupBox3;
        private Button btnEliminarCliente;
        private Label label11;
        private TextBox txtElimClienteDNI;
        private ComboBox cmbNHabilitado;
        private ComboBox cmbModCliente;
    }
}