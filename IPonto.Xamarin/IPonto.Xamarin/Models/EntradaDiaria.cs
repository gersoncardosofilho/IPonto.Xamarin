using System;
using System.Collections.Generic;
using System.Text;
using IPonto.Xamarin.Enums;

namespace IPonto.Xamarin.Models
{
    public class EntradaDiaria
    {
        public ETipoEntrada TipoEntrada { get; set; }
        public DateTime Dia { get; set; }
        public DateTime EntradaManha { get; set; }
        public DateTime SaidaManha { get; set; }
        public DateTime EntradaTarde { get; set; }
        public DateTime SaidaTarde { get; set; }

    }
}
