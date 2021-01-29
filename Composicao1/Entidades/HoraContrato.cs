using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao1.Entidades {
    class HoraContrato {

        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HoraContrato(DateTime data, double valorPorHora, int horas) {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal() {
            return Horas * ValorPorHora;
        }
    }
}
