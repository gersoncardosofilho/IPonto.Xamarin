using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPonto.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPonto.Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisualizarPage : ContentPage
    {
        public VisualizarPage()
        {
            InitializeComponent();
            
            


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();



            var entradas = await App.Database.GetAllEntradasAsync();

            var sortedEntradas = entradas.OrderBy(c => c.Dia).ToList();

            listView.ItemsSource = sortedEntradas;
            listView.IsPullToRefreshEnabled = true;

        }

        private async Task ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            CadastroEntrada cad = e.SelectedItem as CadastroEntrada;

            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new EditarPage(cad));
            }




            

            
        }
    }
}