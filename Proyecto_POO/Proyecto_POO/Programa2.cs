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
    public partial class Programa2 : Form
    {
        //Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094, Sección: 0908

        public Programa2()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            int Anom = 0, Enom = 0, Inom = 0, Onom = 0, Unom = 0;
            int Aape = 0, Eape = 0, Iape = 0, Oape = 0, Uape = 0;


            for (int i = 0; i < nombre.Length; i++)
            {
                char nom = nombre[i];
                if (nom.ToString() == "A" || nom.ToString() == "a")
                {
                    Anom++;
                }
                if (nom.ToString() == "E" || nom.ToString() == "e")
                {
                    Enom++;
                }
                if (nom.ToString() == "I" || nom.ToString() == "i")
                {
                    Inom++;
                }
                if (nom.ToString() == "O" || nom.ToString() == "o")
                {
                    Onom++;
                }
                if (nom.ToString() == "U" || nom.ToString() == "u")
                {
                    Unom++;
                }

            }


            for (int j = 0; j < apellido.Length; j++)
            {
                char ape = apellido[j];
                if (ape.ToString() == "A" || ape.ToString() == "a")
                {
                    Aape++;
                }
                if (ape.ToString() == "E" || ape.ToString() == "e")
                {
                    Eape++;
                }
                if (ape.ToString() == "I" || ape.ToString() == "i")
                {
                    Iape++;
                }
                if (ape.ToString() == "O" || ape.ToString() == "o")
                {
                    Oape++;
                }
                if (ape.ToString() == "U" || ape.ToString() == "u")
                {
                    Uape++;
                }

            }


            TxtAnom.Text = Convert.ToString(Anom);
            TxtEnom.Text = Convert.ToString(Enom);
            TxtInom.Text = Convert.ToString(Inom);
            TxtOnom.Text = Convert.ToString(Onom);
            TxtUnom.Text = Convert.ToString(Unom);


            TxtAape.Text = Convert.ToString(Aape);
            TxtEape.Text = Convert.ToString(Eape);
            TxtIape.Text = Convert.ToString(Iape);
            TxtOape.Text = Convert.ToString(Oape);
            TxtUape.Text = Convert.ToString(Uape);

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
