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
    public partial class Programa3 : Form
    {
        //Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094, Sección: 0908

        public Programa3()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            LbTabla.Items.Clear();
            TxtFactorial.Text = "";

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            try
            {
                if (TxtMultiplicando.Text == "")
                {
                    MessageBox.Show("El campo Multiplicando no puede dejarse vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtMultiplicando.Focus();
                }
                else if (TxtMultiplicador.Text == "")
                {
                    MessageBox.Show("El campo multiplicador no puede dejarse vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtMultiplicador.Focus();
                }
                else
                {

                    int multiplicando = Convert.ToInt16(TxtMultiplicando.Text);
                    int multiplicador = Convert.ToInt16(TxtMultiplicador.Text);
                    int factorial = multiplicando;

                    Limpiar();

                    if (multiplicando <= 0)
                    {
                        MessageBox.Show("El numero ingresado debe ser un numero entero.");
                        TxtMultiplicando.Text = "";
                        TxtMultiplicando.Focus();
                    }
                    else if (multiplicando > 33)
                    {
                        MessageBox.Show("Favor intente con otro numero, no se soporta la longitud del resultado factorial.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtMultiplicando.Text = "";
                        TxtMultiplicando.Focus();
                    }
                    else
                    {
                        //Para calcular la tabla del numero ingresado
                        for (int i = 1; i <= multiplicador; i++)
                        {
                            LbTabla.Items.Add(multiplicando + " x " + i + " = " + (i * multiplicando));
                        }

                        //Para calcular el factorial del numero ingresado
                        for (int j = multiplicando - 1; j > 0; j--)
                        {
                            factorial *= j; //Equivalente a factorial = factorial * i
                        }

                        TxtFactorial.Text = factorial.ToString();

                    }
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094","Estudiante",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
