namespace Proyecto_POO
{
    partial class Programa1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDesde = new System.Windows.Forms.TextBox();
            this.TxtHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbNumPares = new System.Windows.Forms.ListBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LbNumImp = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbDivisibles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEstudiante = new System.Windows.Forms.TextBox();
            this.BtnEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // TxtDesde
            // 
            this.TxtDesde.Location = new System.Drawing.Point(34, 50);
            this.TxtDesde.Name = "TxtDesde";
            this.TxtDesde.Size = new System.Drawing.Size(100, 20);
            this.TxtDesde.TabIndex = 2;
            // 
            // TxtHasta
            // 
            this.TxtHasta.Location = new System.Drawing.Point(34, 109);
            this.TxtHasta.Name = "TxtHasta";
            this.TxtHasta.Size = new System.Drawing.Size(100, 20);
            this.TxtHasta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pares";
            // 
            // LbNumPares
            // 
            this.LbNumPares.FormattingEnabled = true;
            this.LbNumPares.Location = new System.Drawing.Point(188, 45);
            this.LbNumPares.Name = "LbNumPares";
            this.LbNumPares.Size = new System.Drawing.Size(64, 173);
            this.LbNumPares.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(47, 159);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LbNumImp
            // 
            this.LbNumImp.FormattingEnabled = true;
            this.LbNumImp.Location = new System.Drawing.Point(258, 45);
            this.LbNumImp.Name = "LbNumImp";
            this.LbNumImp.Size = new System.Drawing.Size(68, 173);
            this.LbNumImp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Impares";
            // 
            // LbDivisibles
            // 
            this.LbDivisibles.FormattingEnabled = true;
            this.LbDivisibles.Location = new System.Drawing.Point(332, 45);
            this.LbDivisibles.Name = "LbDivisibles";
            this.LbDivisibles.Size = new System.Drawing.Size(75, 173);
            this.LbDivisibles.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Divisibles de 3";
            // 
            // TxtEstudiante
            // 
            this.TxtEstudiante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtEstudiante.Location = new System.Drawing.Point(0, 238);
            this.TxtEstudiante.Name = "TxtEstudiante";
            this.TxtEstudiante.ReadOnly = true;
            this.TxtEstudiante.Size = new System.Drawing.Size(439, 20);
            this.TxtEstudiante.TabIndex = 11;
            this.TxtEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.Location = new System.Drawing.Point(1, 215);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(75, 23);
            this.BtnEstudiante.TabIndex = 12;
            this.BtnEstudiante.Text = "Estudiante";
            this.BtnEstudiante.UseVisualStyleBackColor = true;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // Programa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 258);
            this.Controls.Add(this.BtnEstudiante);
            this.Controls.Add(this.TxtEstudiante);
            this.Controls.Add(this.LbDivisibles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbNumImp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LbNumPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtHasta);
            this.Controls.Add(this.TxtDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Programa1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDesde;
        private System.Windows.Forms.TextBox TxtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbNumPares;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.ListBox LbNumImp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbDivisibles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEstudiante;
        private System.Windows.Forms.Button BtnEstudiante;
    }
}