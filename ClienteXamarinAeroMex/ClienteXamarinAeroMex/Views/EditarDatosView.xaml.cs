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
    public partial class EditarDatosView : ContentPage
    {
        public EditarDatosView(Vuelo vuelo)
        {
            BindingContext = vuelo;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        PrincipalViewModel vm;
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            vm = new PrincipalViewModel();
            vm.Vuelo = new Vuelo
            {
                CodigoVuelo = Codigo.Text, Salida=Salida.Text, Hora=Hora.Time, Estado=EstadoPicker.SelectedItem.ToString(), HoraLlegada=Llegada.Time,IdVuelo=int.Parse(id.Text) 

            };
            vm.EstadoSeleccionado = EstadoPicker.SelectedItem as Estado;
            vm.GuardarCommand.Execute(vm);
        }

      
    }
}