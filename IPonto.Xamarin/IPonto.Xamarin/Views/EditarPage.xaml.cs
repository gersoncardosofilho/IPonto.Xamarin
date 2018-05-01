using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPonto.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IPonto.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditarPage : ContentPage
	{
	    private CadastroEntrada cadastroEntrada;

		public EditarPage (CadastroEntrada cad)
		{
			InitializeComponent ();

            BindingContext = new CadastroEntrada()
            {
                IdEntrada = cad.IdEntrada,
                Entrada = cad.Entrada,
                TipoEntrada = cad.TipoEntrada
            };

            //cadastroEntrada = new CadastroEntrada()
            //{
            //    IdEntrada = cad.IdEntrada,
            //    Entrada = cad.Entrada,
            //    TipoEntrada = cad.TipoEntrada
            //};
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        var entrada = (CadastroEntrada) BindingContext;
	        await App.Database.SaveEntradaAsync(entrada);
	        await Navigation.PopAsync();
	    }
	}
}