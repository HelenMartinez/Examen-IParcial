using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelenMartínez
{
    public partial class SegundoFormulario : Form
    {
        public SegundoFormulario()
        {
            InitializeComponent();
        }

        decimal subtotal, totalaPagar;
        private async void Calculobutton_Click(object sender, EventArgs e)
        {
            //string producto = ProductoTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);
            decimal cantidad = Convert.ToDecimal(CantidadTextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);
            decimal cantidad2 = Convert.ToDecimal(Cantidad2TextBox.Text);
                     
            decimal total = await DescuentoAsync(precio, cantidad, precio2, cantidad2, subtotal,totalaPagar);
                     
            CalculototalTextBox.Text = total.ToString();
        }

        private async Task<decimal> DescuentoAsync(decimal precio, decimal cant, decimal precio2,
                                                   decimal cant2, decimal descuento, decimal subtotal)                                                          
        {
            decimal TotalPagar = await Task.Run(() =>
            {              
                subtotal = (precio * cant) + (precio2 * cant2);                               
                descuento = subtotal * 15 / 100;
                
                return subtotal - descuento;
            });
            return TotalPagar;
        }
    }
}
