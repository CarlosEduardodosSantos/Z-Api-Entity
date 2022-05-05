using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Api.Zip
{
    public partial class Siemp
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Fax { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Responsavel { get; set; }
        public string Fone { get; set; }
        public bool? ContribuinteSt { get; set; }
        public bool? ContribuinteIpi { get; set; }
        public int Loja { get; set; }
        public int? Nfnro { get; set; }
        public short? Nfserie { get; set; }
        public short? Nfmod { get; set; }
        public string Im { get; set; }
        public decimal? PercCredIcms { get; set; }
        public string Cnae { get; set; }
        public int? Crt { get; set; }
        public string CodAtivSat { get; set; }
        public int? FabricanteSat { get; set; }
        public int? AmbienteSat { get; set; }
        public string SignAcsat { get; set; }
        public int? GeraXmlsat { get; set; }
        public int? TipoExtratoSat { get; set; }
        public int? DesignerSat { get; set; }
        public string VersaoLayoutSat { get; set; }
        public string CnpjsoftwareHouse { get; set; }
        public string Cnpjrede { get; set; }
        public string NomeFantasia { get; set; }
    }
}
