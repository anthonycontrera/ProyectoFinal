namespace Proyecto_POO
{
    partial class FrmMenu
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
            this.BtnPrograma1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnPrograma2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnPrograma3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrograma1
            // 
            this.BtnPrograma1.Location = new System.Drawing.Point(12, 30);
            this.BtnPrograma1.Name = "BtnPrograma1";
            this.BtnPrograma1.Size = new System.Drawing.Size(73, 29);
            this.BtnPrograma1.TabIndex = 0;
            this.BtnPrograma1.Text = "Programa 1";
            this.BtnPrograma1.UseVisualStyleBackColor = true;
            this.BtnPrograma1.Click += new System.EventHandler(this.BtnPrograma1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "●Imprime los Numeros Pares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "●Imprime los Numeros Impares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "●Imprime los divisibles de 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "●Calcula las vocales que contiene tu apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "●Calcula las vocales que contiene tu nombre";
            // 
            // BtnPrograma2
            // 
            this.BtnPrograma2.Location = new System.Drawing.Point(12, 98);
            this.BtnPrograma2.Name = "BtnPrograma2";
            this.BtnPrograma2.Size = new System.Drawing.Size(73, 29);
            this.BtnPrograma2.TabIndex = 4;
            this.BtnPrograma2.Text = "Programa 2";
            this.BtnPrograma2.UseVisualStyleBackColor = true;
            this.BtnPrograma2.Click += new System.EventHandler(this.BtnPrograma2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "●Calcula el factorial de un numero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "●Calcular la tabla numerica de un numero";
            // 
            // BtnPrograma3
            // 
            this.BtnPrograma3.Location = new System.Drawing.Point(12, 162);
            this.BtnPrograma3.Name = "BtnPrograma3";
            this.BtnPrograma3.Size = new System.Drawing.Size(73, 29);
            this.BtnPrograma3.TabIndex = 7;
            this.BtnPrograma3.Text = "Programa 3";
            this.BtnPrograma3.UseVisualStyleBackColor = true;
            this.BtnPrograma3.Click += new System.EventHandler(this.BtnPrograma3_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 226);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnPrograma3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnPrograma2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrograma1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrograma1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnPrograma2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnPrograma3;
    }
}

