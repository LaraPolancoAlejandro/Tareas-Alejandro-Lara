namespace BARBERIA
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbServicio = new System.Windows.Forms.ComboBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Servi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tbdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Hora = new System.Windows.Forms.Label();
            this.tbdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefono";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbServicio
            // 
            this.tbServicio.BackColor = System.Drawing.Color.White;
            this.tbServicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServicio.FormattingEnabled = true;
            this.tbServicio.Items.AddRange(new object[] {
            "Cabeza",
            "Barba",
            "Completo"});
            this.tbServicio.Location = new System.Drawing.Point(90, 97);
            this.tbServicio.Name = "tbServicio";
            this.tbServicio.Size = new System.Drawing.Size(172, 26);
            this.tbServicio.TabIndex = 3;
            this.tbServicio.Text = "tipo de servicio";
            this.tbServicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(90, 53);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(90, 9);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // Servi
            // 
            this.Servi.AutoSize = true;
            this.Servi.BackColor = System.Drawing.Color.Transparent;
            this.Servi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servi.Location = new System.Drawing.Point(1, 97);
            this.Servi.Name = "Servi";
            this.Servi.Size = new System.Drawing.Size(84, 22);
            this.Servi.TabIndex = 11;
            this.Servi.Text = "Servicio";
            this.Servi.Click += new System.EventHandler(this.Servi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(633, 29);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(104, 44);
            this.Agregar.TabIndex = 14;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(633, 97);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(104, 44);
            this.Borrar.TabIndex = 15;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(633, 173);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(104, 44);
            this.Salir.TabIndex = 16;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(129, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(539, 185);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tbdateTimePicker2
            // 
            this.tbdateTimePicker2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdateTimePicker2.Location = new System.Drawing.Point(90, 141);
            this.tbdateTimePicker2.Name = "tbdateTimePicker2";
            this.tbdateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.tbdateTimePicker2.TabIndex = 18;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(1, 182);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(54, 22);
            this.Hora.TabIndex = 19;
            this.Hora.Text = "Hora";
            // 
            // tbdateTimePicker1
            // 
            this.tbdateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tbdateTimePicker1.Location = new System.Drawing.Point(90, 184);
            this.tbdateTimePicker1.Name = "tbdateTimePicker1";
            this.tbdateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.tbdateTimePicker1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(797, 532);
            this.Controls.Add(this.tbdateTimePicker1);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.tbdateTimePicker2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Servi);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbServicio;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label Servi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DateTimePicker tbdateTimePicker2;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.DateTimePicker tbdateTimePicker1;
    }
}

