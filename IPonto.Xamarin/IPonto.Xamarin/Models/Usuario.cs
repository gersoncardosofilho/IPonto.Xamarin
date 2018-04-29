using System;
using System.Collections.Generic;
using System.Text;

namespace IPonto.Xamarin.Models
{
    class Usuario
    {
        public string Filial { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public int HorarioEntrada { get; set; }
        public int HorarioSaida { get; set; }
        public string Competencia { get; set; }
    }
}
