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
            btnModificarSeguro = new Button();
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
            groupBox3.Location = new Point(14, 244);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(802, 92);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Seguro";
            // 
            // btnEliminarSeguro
            // 
            btnEliminarSeguro.Location = new Point(403, 44);
            btnEliminarSeguro.Margin = new Padding(3, 4, 3, 4);
            btnEliminarSeguro.Name = "btnEliminarSeguro";
            btnEliminarSeguro.Size = new Size(382, 31);
            btnEliminarSeguro.TabIndex = 11;
            btnEliminarSeguro.Text = "Eliminar Seguro";
            btnEliminarSeguro.UseVisualStyleBackColor = true;
            btnEliminarSeguro.Click += btnEliminarSeguro_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 20);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 3;
            label11.Text = "ID Seguro";
            // 
            // txtElimSeguro
            // 
            txtElimSeguro.Location = new Point(7, 44);
            txtElimSeguro.Margin = new Padding(3, 4, 3, 4);
            txtElimSeguro.Name = "txtElimSeguro";
            txtElimSeguro.Size = new Size(389, 27);
            txtElimSeguro.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModificarSeguro);
            groupBox2.Controls.Add(txtModSeguroPrecio);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtModID);
            groupBox2.Location = new Point(419, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(397, 220);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Seguro";
            // 
            // btnModificarSeguro
            // 
            btnModificarSeguro.Location = new Point(7, 148);
            btnModificarSeguro.Margin = new Padding(3, 4, 3, 4);
            btnModificarSeguro.Name = "btnModificarSeguro";
            btnModificarSeguro.Size = new Size(373, 64);
            btnModificarSeguro.TabIndex = 24;
            btnModificarSeguro.Text = "Modificar Precio";
            btnModificarSeguro.UseVisualStyleBackColor = true;
            btnModificarSeguro.Click += btnModificarSeguro_Click;
            // 
            // txtModSeguroPrecio
            // 
            txtModSeguroPrecio.Location = new Point(7, 108);
            txtModSeguroPrecio.Margin = new Padding(3, 4, 3, 4);
            txtModSeguroPrecio.Name = "txtModSeguroPrecio";
            txtModSeguroPrecio.Size = new Size(372, 27);
            txtModSeguroPrecio.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 84);
            label13.Name = "label13";
            label13.Size = new Size(50, 20);
            label13.TabIndex = 22;
            label13.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 25);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 3;
            label10.Text = "ID Seguro";
            // 
            // txtModID
            // 
            txtModID.Location = new Point(7, 49);
            txtModID.Margin = new Padding(3, 4, 3, 4);
            txtModID.Name = "txtModID";
            txtModID.Size = new Size(372, 27);
            txtModID.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearSeguro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCSeguroPrecio);
            groupBox1.Controls.Add(txtCSeguroNombre);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(397, 220);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Seguro";
            // 
            // btnCrearSeguro
            // 
            btnCrearSeguro.Location = new Point(7, 148);
            btnCrearSeguro.Margin = new Padding(3, 4, 3, 4);
            btnCrearSeguro.Name = "btnCrearSeguro";
            btnCrearSeguro.Size = new Size(373, 64);
            btnCrearSeguro.TabIndex = 11;
            btnCrearSeguro.Text = "Crear Seguro";
            btnCrearSeguro.UseVisualStyleBackColor = true;
            btnCrearSeguro.Click += btnCrearSeguro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 27);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre del Seguro";
            // 
            // txtCSeguroPrecio
            // 
            txtCSeguroPrecio.Location = new Point(7, 109);
            txtCSeguroPrecio.Margin = new Padding(3, 4, 3, 4);
            txtCSeguroPrecio.Name = "txtCSeguroPrecio";
            txtCSeguroPrecio.Size = new Size(372, 27);
            txtCSeguroPrecio.TabIndex = 1;
            // 
            // txtCSeguroNombre
            // 
            txtCSeguroNombre.Location = new Point(7, 51);
            txtCSeguroNombre.Margin = new Padding(3, 4, 3, 4);
            txtCSeguroNombre.Name = "txtCSeguroNombre";
            txtCSeguroNombre.Size = new Size(372, 27);
            txtCSeguroNombre.TabIndex = 0;
            // 
            // dgvSeguros
            // 
            dgvSeguros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguros.Location = new Point(14, 344);
            dgvSeguros.Margin = new Padding(3, 4, 3, 4);
            dgvSeguros.Name = "dgvSeguros";
            dgvSeguros.RowHeadersWidth = 51;
            dgvSeguros.Size = new Size(802, 200);
            dgvSeguros.TabIndex = 10;
            // 
            // ABMSeguro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 560);
            Controls.Add(dgvSeguros);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABMSeguro";
            Text = "ABMSeguro";
            Load += ABMSeguro_Load;
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