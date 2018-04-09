namespace Proyecto_POO
{
    partial class Programa3
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
            this.TxtMultiplicando = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LbTabla = new System.Windows.Forms.ListBox();
            this.TxtFactorial = new System.Windows.Forms.TextBox();
            this.TxtMultiplicador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMultiplicando
            // 
            this.TxtMultiplicando.Location = new System.Drawing.Point(24, 32);
            this.TxtMultiplicando.MaxLength = 3;
            this.TxtMultiplicando.Name = "TxtMultiplicando";
            this.TxtMultiplicando.Size = new System.Drawing.Size(100, 20);
            this.TxtMultiplicando.TabIndex = 0;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(175, 52);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LbTabla
            // 
            this.LbTabla.FormattingEnabled = true;
            this.LbTabla.Location = new System.Drawing.Point(24, 123);
            this.LbTabla.Name = "LbTabla";
            this.LbTabla.Size = new System.Drawing.Size(120, 160);
            this.LbTabla.TabIndex = 3;
            // 
            // TxtFactorial
            // 
            this.TxtFactorial.Location = new System.Drawing.Point(161, 123);
            this.TxtFactorial.MaxLength = 327670000;
            this.TxtFactorial.Name = "TxtFactorial";
            this.TxtFactorial.ReadOnly = true;
            this.TxtFactorial.Size = new System.Drawing.Size(100, 20);
            this.TxtFactorial.TabIndex = 4;
            // 
            // TxtMultiplicador
            // 
            this.TxtMultiplicador.Location = new System.Drawing.Point(24, 78);
            this.TxtMultiplicador.MaxLength = 3;
            this.TxtMultiplicador.Name = "TxtMultiplicador";
            this.TxtMultiplicador.Size = new System.Drawing.Size(100, 20);
            this.TxtMultiplicador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multiplicando:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Multiplicador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Factorial";
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.Location = new System.Drawing.Point(175, 193);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(75, 23);
            this.BtnEstudiante.TabIndex = 9;
            this.BtnEstudiante.Text = "Estudiante";
            this.BtnEstudiante.UseVisualStyleBackColor = true;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // Programa3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 295);
            this.Controls.Add(this.BtnEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMultiplicador);
            this.Controls.Add(this.TxtFactorial);
            this.Controls.Add(this.LbTabla);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtMultiplicando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Programa3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMultiplicando;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.ListBox LbTabla;
        private System.Windows.Forms.TextBox TxtFactorial;
        private System.Windows.Forms.TextBox TxtMultiplicador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEstudiante;
    }
}