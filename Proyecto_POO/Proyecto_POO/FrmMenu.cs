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
    public partial class FrmMenu : Form
    {

        //Nombre: Anthony Contrera Charpentier, Matricula: 13-SISN-1-094, Sección: 0908
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnPrograma1_Click(object sender, EventArgs e)
        {
            Programa1 programa1 = new Programa1();
            programa1.Show();
        }

        private void BtnPrograma2_Click(object sender, EventArgs e)
        {
            Programa2 programa2 = new Programa2();
            programa2.Show();
        }

        private void BtnPrograma3_Click(object sender, EventArgs e)
        {
            Programa3 programa3 = new Programa3();
            programa3.Show();
        }
    }
}
