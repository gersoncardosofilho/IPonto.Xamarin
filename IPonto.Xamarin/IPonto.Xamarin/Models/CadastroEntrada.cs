using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using SQLite;

namespace IPonto.Xamarin.Models
{
    public class CadastroEntrada
    {
        private CultureInfo ci;

        public CadastroEntrada()
        {
            ci = new CultureInfo("pt-BR");
        }

        [PrimaryKey, AutoIncrement]
        public int IdEntrada { get; set; }

        public string TipoEntrada { get; set; }
        public DateTime Entrada { get; set; }

        public int Dia
        {
            get { return Entrada.Day; }

        }

        public string DiaDaSemana
        {
            get { return ci.DateTimeFormat.GetDayName(Entrada.DayOfWeek); }
        }

        public string Hora
        {
            get
            {
                return Entrada.ToString("hh:mm:ss");
            }
        }

    }
}
