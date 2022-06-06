namespace PROYECTO_1
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
            this.Título = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AFP = new System.Windows.Forms.Label();
            this.IRS = new System.Windows.Forms.Label();
            this.SFS = new System.Windows.Forms.Label();
            this.SueldoNeto = new System.Windows.Forms.Label();
            this.SueldoBrutoTB = new System.Windows.Forms.TextBox();
            this.AFPTB = new System.Windows.Forms.TextBox();
            this.IRSTB = new System.Windows.Forms.TextBox();
            this.SFSTB = new System.Windows.Forms.TextBox();
            this.SueldoNetoTB = new System.Windows.Forms.TextBox();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Título
            // 
            this.Título.AutoSize = true;
            this.Título.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Título.Location = new System.Drawing.Point(252, 9);
            this.Título.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Título.Name = "Título";
            this.Título.Size = new System.Drawing.Size(697, 46);
            this.Título.TabIndex = 0;
            this.Título.Text = "Calculo de Nómina del trabajador";
            this.Título.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo Bruto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AFP
            // 
            this.AFP.AutoSize = true;
            this.AFP.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFP.Location = new System.Drawing.Point(273, 245);
            this.AFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AFP.Name = "AFP";
            this.AFP.Size = new System.Drawing.Size(54, 24);
            this.AFP.TabIndex = 2;
            this.AFP.Text = "AFP";
            // 
            // IRS
            // 
            this.IRS.AutoSize = true;
            this.IRS.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRS.Location = new System.Drawing.Point(273, 320);
            this.IRS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IRS.Name = "IRS";
            this.IRS.Size = new System.Drawing.Size(48, 24);
            this.IRS.TabIndex = 3;
            this.IRS.Text = "IRS";
            // 
            // SFS
            // 
            this.SFS.AutoSize = true;
            this.SFS.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFS.Location = new System.Drawing.Point(273, 395);
            this.SFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SFS.Name = "SFS";
            this.SFS.Size = new System.Drawing.Size(48, 24);
            this.SFS.TabIndex = 4;
            this.SFS.Text = "SFS";
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.AutoSize = true;
            this.SueldoNeto.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SueldoNeto.Location = new System.Drawing.Point(273, 477);
            this.SueldoNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SueldoNeto.Name = "SueldoNeto";
            this.SueldoNeto.Size = new System.Drawing.Size(121, 24);
            this.SueldoNeto.TabIndex = 5;
            this.SueldoNeto.Text = "Sueldo Neto";
            // 
            // SueldoBrutoTB
            // 
            this.SueldoBrutoTB.Location = new System.Drawing.Point(482, 166);
            this.SueldoBrutoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SueldoBrutoTB.Name = "SueldoBrutoTB";
            this.SueldoBrutoTB.Size = new System.Drawing.Size(226, 26);
            this.SueldoBrutoTB.TabIndex = 6;
            // 
            // AFPTB
            // 
            this.AFPTB.Location = new System.Drawing.Point(482, 251);
            this.AFPTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AFPTB.Name = "AFPTB";
            this.AFPTB.ReadOnly = true;
            this.AFPTB.Size = new System.Drawing.Size(226, 26);
            this.AFPTB.TabIndex = 7;
            this.AFPTB.TextChanged += new System.EventHandler(this.AFPTB_TextChanged);
            // 
            // IRSTB
            // 
            this.IRSTB.Location = new System.Drawing.Point(483, 326);
            this.IRSTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IRSTB.Name = "IRSTB";
            this.IRSTB.ReadOnly = true;
            this.IRSTB.Size = new System.Drawing.Size(224, 26);
            this.IRSTB.TabIndex = 8;
            // 
            // SFSTB
            // 
            this.SFSTB.Location = new System.Drawing.Point(482, 398);
            this.SFSTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SFSTB.Name = "SFSTB";
            this.SFSTB.ReadOnly = true;
            this.SFSTB.Size = new System.Drawing.Size(226, 26);
            this.SFSTB.TabIndex = 9;
            // 
            // SueldoNetoTB
            // 
            this.SueldoNetoTB.Location = new System.Drawing.Point(482, 483);
            this.SueldoNetoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SueldoNetoTB.Name = "SueldoNetoTB";
            this.SueldoNetoTB.ReadOnly = true;
            this.SueldoNetoTB.Size = new System.Drawing.Size(226, 26);
            this.SueldoNetoTB.TabIndex = 10;
            // 
            // CALCULAR
            // 
            this.CALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(402, 598);
            this.CALCULAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(398, 60);
            this.CALCULAR.TabIndex = 11;
            this.CALCULAR.Text = "Calcular nómina";
            this.CALCULAR.UseVisualStyleBackColor = true;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(1069, 608);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(118, 43);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.CALCULAR);
            this.Controls.Add(this.SueldoNetoTB);
            this.Controls.Add(this.SFSTB);
            this.Controls.Add(this.IRSTB);
            this.Controls.Add(this.AFPTB);
            this.Controls.Add(this.SueldoBrutoTB);
            this.Controls.Add(this.SueldoNeto);
            this.Controls.Add(this.SFS);
            this.Controls.Add(this.IRS);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Título);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Título;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AFP;
        private System.Windows.Forms.Label IRS;
        private System.Windows.Forms.Label SFS;
        private System.Windows.Forms.Label SueldoNeto;
        private System.Windows.Forms.TextBox SueldoBrutoTB;
        private System.Windows.Forms.TextBox AFPTB;
        private System.Windows.Forms.TextBox IRSTB;
        private System.Windows.Forms.TextBox SFSTB;
        private System.Windows.Forms.TextBox SueldoNetoTB;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button1;
    }
}

