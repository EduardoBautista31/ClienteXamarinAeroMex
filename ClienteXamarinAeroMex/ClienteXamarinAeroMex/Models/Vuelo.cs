using System;
using System.Collections.Generic;
using System.Text;

namespace ClienteXamarin.Models
{
    public class Vuelo
    {
        public int IdVuelo { get; set; }
        public TimeSpan Hora { get; set; }
        public string Salida { get; set; } = "";
        public TimeSpan HoraLlegada { get; set; }
        public string CodigoVuelo { get; set; } = "";
        public string Estado { get; set; } = "";
    }
}
