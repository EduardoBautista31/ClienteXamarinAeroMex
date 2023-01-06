using ClienteXamarin.Models;
using ClienteXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aeropuerto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerVuelosPagina : ContentPage
    {
        public VerVuelosPagina()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DatosView());
        }
        PrincipalViewModel vm;
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            vm = new PrincipalViewModel();
            vm.Vuelo = Lista.SelectedItem as Vuelo;
            if (vm.Vuelo!=null)
            {
                Navigation.PushModalAsync(new EditarDatosView(vm.Vuelo));

            }

        }
    }
}