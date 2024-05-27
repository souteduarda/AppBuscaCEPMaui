using AppBuscaCEPMaui.Models;
using AppBuscaCEPMaui.Services;
using System.Data;

namespace AppBuscaCEPMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Endereco dados_endereco = await DataServices.GetEnderecoByCep(txt_cep.Text);

                BindingContext = dados_endereco;
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                List<Bairro> arr_bairros = await DataServices.GetBairrosByIdCidade(4874);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
