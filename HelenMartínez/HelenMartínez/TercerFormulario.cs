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
    public partial class TercerFormulario : Form
    {
        public TercerFormulario()
        {
            InitializeComponent();
        }

        private void CalculoButton_Click(object sender, EventArgs e)
        {           
            int numero;
            
            for (numero = 1; numero <= 100; numero++)
            {
                NumerosListBox.Items.Add(numero);
                if (numero % 3 == 0)
                {
                    Multiplos3ListBox.Items.Add(numero + "   Helen");
                }
                if (numero % 5 == 0)
                {
                    Multiplos5ListBox2.Items.Add(numero + "   Martinez");
                }
                if (numero % 3 == 0 && numero % 5 == 0) 
                {
                    NombreApellidoListBox.Items.Add(numero +"  Helen Martinez");
                }

            }                     
         

        }

    }
}
