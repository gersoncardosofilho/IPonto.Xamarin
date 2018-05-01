using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPonto.Xamarin.Data;
using IPonto.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPonto.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPage : ContentPage
    {

        public RegistrarPage()
        {
            
            InitializeComponent();
        }

        private async Task Button_OnClicked(object sender, EventArgs e)
        {
            var entrada = new CadastroEntrada();

            entrada.TipoEntrada = TipoEntradaPicker.SelectedItem.ToString();
            entrada.Entrada = DateTime.Now;

            //var indicator = new ActivityIndicator();
            //indicator.SetBinding(ActivityIndicator.IsRunningProperty, "Gravando...");
            //indicator.BindingContext = entrada;


            await App.Database.SaveEntradaAsync(entrada);
            //await App.Database.SaveItemAsync(todoItem);
            //await Navigation.PopAsync();


            Debug.WriteLine(entrada);
        }



    }
}