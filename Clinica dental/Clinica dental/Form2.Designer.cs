namespace Clinica_dental
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.TP = new System.Windows.Forms.DateTimePicker();
            this.DP = new System.Windows.Forms.DateTimePicker();
            this.BTagregar = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.BTsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(360, 37);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(358, 42);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Clínica Dr. Muelitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de pacientes";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora";
            // 
            // TBnombre
            // 
            this.TBnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBnombre.Location = new System.Drawing.Point(412, 220);
            this.TBnombre.Multiline = true;
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(167, 24);
            this.TBnombre.TabIndex = 10;
            // 
            // TBapellido
            // 
            this.TBapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBapellido.Location = new System.Drawing.Point(412, 263);
            this.TBapellido.Multiline = true;
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(167, 24);
            this.TBapellido.TabIndex = 11;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtelefono.Location = new System.Drawing.Point(412, 305);
            this.TBtelefono.Multiline = true;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(167, 24);
            this.TBtelefono.TabIndex = 12;
            // 
            // TP
            // 
            this.TP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TP.Location = new System.Drawing.Point(412, 394);
            this.TP.Name = "TP";
            this.TP.Size = new System.Drawing.Size(167, 20);
            this.TP.TabIndex = 15;
            // 
            // DP
            // 
            this.DP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DP.Location = new System.Drawing.Point(412, 353);
            this.DP.Name = "DP";
            this.DP.Size = new System.Drawing.Size(167, 20);
            this.DP.TabIndex = 16;
            // 
            // BTagregar
            // 
            this.BTagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTagregar.Location = new System.Drawing.Point(788, 220);
            this.BTagregar.Name = "BTagregar";
            this.BTagregar.Size = new System.Drawing.Size(104, 39);
            this.BTagregar.TabIndex = 17;
            this.BTagregar.TabStop = false;
            this.BTagregar.Text = "Agregar";
            this.BTagregar.UseVisualStyleBackColor = true;
            this.BTagregar.Click += new System.EventHandler(this.BTagregar_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTborrar.Location = new System.Drawing.Point(788, 298);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(104, 39);
            this.BTborrar.TabIndex = 18;
            this.BTborrar.TabStop = false;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // BTsalir
            // 
            this.BTsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTsalir.Location = new System.Drawing.Point(788, 376);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(104, 39);
            this.BTsalir.TabIndex = 19;
            this.BTsalir.TabStop = false;
            this.BTsalir.Text = "Salir";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(367, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 185);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1206, 709);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTsalir);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTagregar);
            this.Controls.Add(this.DP);
            this.Controls.Add(this.TP);
            this.Controls.Add(this.TBtelefono);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Registro de pacientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.DateTimePicker TP;
        private System.Windows.Forms.DateTimePicker DP;
        private System.Windows.Forms.Button BTagregar;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Button BTsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}