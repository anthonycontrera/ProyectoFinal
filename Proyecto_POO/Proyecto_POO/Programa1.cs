using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    //Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094, Sección: 0908

    public partial class Programa1 : Form
    {
        public Programa1()
        {
            InitializeComponent();
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtDesde.Text == "")
                {
                    MessageBox.Show("El campo Desde no puede dejarse vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtDesde.Focus();
                }
                else if (TxtHasta.Text == "")
                {
                    MessageBox.Show("El campo Hasta no puede dejarse vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtHasta.Focus();
                }
                else
                {
                    int num1 = Convert.ToInt16(TxtDesde.Text);
                    int num2 = Convert.ToInt16(TxtHasta.Text);

                    //Bucle 1 para calcular los Numeros Pares
                    for (int i = num1; i < num2; i++)
                    {
                        if (i % 2 != 0)
                        {
                            i++;
                        }

                        LbNumPares.Items.Add(i);
                    }

                    //Bucle 2 para calcular los Numeros Impares
                    for (int j = num1; j < num2; j++)
                    {
                        if (j % 2 == 0)
                        {
                            j++;
                        }

                        LbNumImp.Items.Add(j);
                    }


                    //Bucle 3 para calcular los Numeros divisibles de 3
                    for (int h = num1; h < num2; h++)
                    {
                        if (h % 3 == 0)
                        {
                            LbDivisibles.Items.Add(h);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            if (TxtEstudiante.Text == "")
            {
                TxtEstudiante.Text = "Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094";
            }
            else
            {
                TxtEstudiante.Text = "";
            }
        }
    }
}
