using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelenMartínez
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //private void Formulario1Button_Click(object sender, EventArgs e)
        //{
        //    //PrimerFormulario formulario1 = new PrimerFormulario();
        //    //formulario1.Show();
        //}

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerFormulario primerformulario = new PrimerFormulario();
            primerformulario.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TercerFormulario tercerformulario = new TercerFormulario();
            tercerformulario.Show();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegundoFormulario segundoformulario = new SegundoFormulario();
            segundoformulario.Show();
        }
    }
}
