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
    public partial class PrimerFormulario : Form
    {
        public PrimerFormulario()
        {
            InitializeComponent();
        }


        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {
            double Interes, Tasa, InteresTotal, Capital;
            int Tiempo;

            Capital = 200000; Tasa = 0.015; Tiempo = 1; InteresTotal = 0;

            string[] Mes = { "Enero","Febrero","Marzo","Abril","Mayo","Junio",
                             "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"
            };

            for (int cont = 0; cont < Mes.Length; cont++) 
            {
                Interes = Capital * Tasa * Tiempo;
                InteresTotal = Interes + Capital;

                Interes = Math.Round(Interes,2);
                InteresTotal = Math.Round(InteresTotal,2);

                MesesListBox.Items.Add(Mes[cont]);
                InteresListBox.Items.Add(Interes);
                InteresTotalListBox.Items.Add(InteresTotal);
                Capital = InteresTotal;
            }


        }

    }
}
