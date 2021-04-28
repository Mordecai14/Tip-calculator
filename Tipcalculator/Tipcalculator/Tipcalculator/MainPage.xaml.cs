using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tipcalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            var total = (decimal.Parse(txtTotal.Text));
            var propina = (decimal.Parse(txtPropina.Text));
            var personas = (decimal.Parse(txtNoPersonas.Text));

            var totalPropina = ((total * propina) / 100);

            labelPropina.Detail = totalPropina.ToString("C");
            labelTotal.Detail = (totalPropina + total).ToString("C");
            labelPropinaPorPersona.Detail = (totalPropina / personas).ToString("C");
            labelTotalPorpersona.Detail = ((total + totalPropina) / personas).ToString("C");
        }

    }
}
