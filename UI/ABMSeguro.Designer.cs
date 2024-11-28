namespace UI
{
    partial class ABMSeguro
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
            btnEliminarSeguro = new Button();
            label11 = new Label();
            txtElimSeguro = new TextBox();
            groupBox2 = new GroupBox();
            txtModSeguroPrecio = new TextBox();
            label13 = new Label();
            label10 = new Label();
            txtModID = new TextBox();
            groupBox1 = new GroupBox();
            btnCrearSeguro = new Button();
            label2 = new Label();
            label1 = new Label();
            txtCSeguroPrecio = new TextBox();
            txtCSeguroNombre = new TextBox();
            btnModificarSeguro = new Button();
            dgvSeguros = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguros).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarSeguro);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtElimSeguro);
            groupBox3.Location = new Point(12, 183);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(702, 69);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Seguro";
            // 
            // btnEliminarSeguro
            // 
            btnEliminarSeguro.Location = new Point(353, 33);
            btnEliminarSeguro.Name = "btnEliminarSeguro";
            btnEliminarSeguro.Size = new Size(334, 23);
            btnEliminarSeguro.TabIndex = 11;
            btnEliminarSeguro.Text = "Eliminar Seguro";
            btnEliminarSeguro.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 15);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 3;
            label11.Text = "ID Seguro";
            // 
            // txtElimSeguro
            // 
            txtElimSeguro.Location = new Point(6, 33);
            txtElimSeguro.Name = "txtElimSeguro";
            txtElimSeguro.Size = new Size(341, 23);
            txtElimSeguro.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModificarSeguro);
            groupBox2.Controls.Add(txtModSeguroPrecio);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtModID);
            groupBox2.Location = new Point(367, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 165);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Seguro";
            // 
            // txtModSeguroPrecio
            // 
            txtModSeguroPrecio.Location = new Point(6, 81);
            txtModSeguroPrecio.Name = "txtModSeguroPrecio";
            txtModSeguroPrecio.Size = new Size(326, 23);
            txtModSeguroPrecio.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 63);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 22;
            label13.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 3;
            label10.Text = "ID Seguro";
            // 
            // txtModID
            // 
            txtModID.Location = new Point(6, 37);
            txtModID.Name = "txtModID";
            txtModID.Size = new Size(326, 23);
            txtModID.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearSeguro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCSeguroPrecio);
            groupBox1.Controls.Add(txtCSeguroNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 165);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Seguro";
            // 
            // btnCrearSeguro
            // 
            btnCrearSeguro.Location = new Point(6, 111);
            btnCrearSeguro.Name = "btnCrearSeguro";
            btnCrearSeguro.Size = new Size(326, 48);
            btnCrearSeguro.TabIndex = 11;
            btnCrearSeguro.Text = "Crear Seguro";
            btnCrearSeguro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Seguro";
            // 
            // txtCSeguroPrecio
            // 
            txtCSeguroPrecio.Location = new Point(6, 82);
            txtCSeguroPrecio.Name = "txtCSeguroPrecio";
            txtCSeguroPrecio.Size = new Size(326, 23);
            txtCSeguroPrecio.TabIndex = 1;
            // 
            // txtCSeguroNombre
            // 
            txtCSeguroNombre.Location = new Point(6, 38);
            txtCSeguroNombre.Name = "txtCSeguroNombre";
            txtCSeguroNombre.Size = new Size(326, 23);
            txtCSeguroNombre.TabIndex = 0;
            // 
            // btnModificarSeguro
            // 
            btnModificarSeguro.Location = new Point(6, 111);
            btnModificarSeguro.Name = "btnModificarSeguro";
            btnModificarSeguro.Size = new Size(326, 48);
            btnModificarSeguro.TabIndex = 24;
            btnModificarSeguro.Text = "Modificar Precio";
            btnModificarSeguro.UseVisualStyleBackColor = true;
            // 
            // dgvSeguros
            // 
            dgvSeguros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguros.Location = new Point(12, 258);
            dgvSeguros.Name = "dgvSeguros";
            dgvSeguros.Size = new Size(702, 150);
            dgvSeguros.TabIndex = 10;
            // 
            // ABMSeguro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 420);
            Controls.Add(dgvSeguros);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ABMSeguro";
            Text = "ABMSeguro";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnEliminarSeguro;
        private Label label11;
        private TextBox txtElimSeguro;
        private GroupBox groupBox2;
        private TextBox txtModSeguroPrecio;
        private Label label13;
        private Label label10;
        private TextBox txtModID;
        private GroupBox groupBox1;
        private Button btnCrearSeguro;
        private Label label2;
        private Label label1;
        private TextBox txtCSeguroPrecio;
        private TextBox txtCSeguroNombre;
        private Button btnModificarSeguro;
        private DataGridView dgvSeguros;
    }
}