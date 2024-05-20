using AppBuscaCEPMaui.Models;
using AppBuscaCEPMaui.Services;

namespace AppBuscaCEPMaui.Views;

public partial class BuscaCepPorLogradouro : ContentPage
{
	public BuscaCepPorLogradouro()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			carregando.IsRunning = true;

			List<Cep> arr_ceps = await DataServices.GetCepsByLogragouro(txt_logradouro.Text);

			lst_ceps.ItemsSource = arr_ceps;
		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
		finally
		{
			carregando.IsRunning = false;
		}
    }
}