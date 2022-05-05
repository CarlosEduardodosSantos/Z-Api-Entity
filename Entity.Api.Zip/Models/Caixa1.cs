using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Api.Zip
{
    public partial class Caixa1
    {
        public int NroCx { get; set; }
        public int? Loja { get; set; }
        public int? Pdv { get; set; }
        public string Usuario { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
        public double? Inicial { get; set; }
        public DateTime? FimData { get; set; }
        public DateTime? FimHora { get; set; }
        public string FimUsuario { get; set; }
        public int? FimLoja { get; set; }
        public DateTime? DataF { get; set; }
        public int? ComandaIni { get; set; }
        public int? ComandaFim { get; set; }
        public Guid? Rowguid { get; set; }
    }
}
