using ClienteXamarin.Models;
using ClienteXamarin.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ClienteXamarin.ViewModels
{
    public class PrincipalViewModel
    {
        public ICommand GuardarCommand { get; set; }
        public Vuelo Vuelo { get; set; } = new Vuelo();
        public Estado EstadoSeleccionado { get; set; }

        public ObservableCollection<Estado> Estados { get; set; } = new ObservableCollection<Estado>();
        public ObservableCollection<Vuelo> Vuelos { get; set; } = new ObservableCollection<Vuelo>();
        private VueloService vueloservice = new VueloService();
        private EstadoService estadoservice = new EstadoService();
        public PrincipalViewModel()
        {
            GuardarCommand = new RelayCommand(Guardar);
            CargarEstados();
            CargarVuelos();
        }
        private async void CargarVuelos()
        {
            Vuelos.Clear();
            var vuelos = await vueloservice.GetVuelos();
            foreach (var item in vuelos)
            {
                Vuelos.Add(item);
            }
        }
        private async void CargarEstados()
        {
            Estados.Clear();
            var estados = await estadoservice.GetEstados();
            foreach (var item in estados)
            {
                Estados.Add(item);
            }
        }
        private async void Guardar()
        {
            Vuelo.Estado = EstadoSeleccionado.Estado1;
            if (Vuelo != null)
                if (Vuelo.IdVuelo == 0)
                {
                    await vueloservice.Insert(Vuelo);
                   
                }
                else
                    await vueloservice.Update(Vuelo);
            CargarVuelos();
        }
    }
}
