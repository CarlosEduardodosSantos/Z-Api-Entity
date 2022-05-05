using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Api.Zip
{
    public partial class Produto
    {
        public int Codigo { get; set; }
        public bool? Ativo { get; set; }
        public int? CategoriaId { get; set; }
        public string Cest { get; set; }
        public string Descricao { get; set; }
        public string Ean { get; set; }
        public double? EstoqueMaximo { get; set; }
        public double? EstoqueMinimo { get; set; }
        public bool? EstoqueNegativo { get; set; }
        public int? MarcaId { get; set; }
        public int? NcmId { get; set; }
        public int? OrigemId { get; set; }
        public bool? ParaVender { get; set; }
        public double? PesoBruto { get; set; }
        public double? PesoLiquido { get; set; }
        public int? ProdutoIntegracaoFiscalId { get; set; }
        public double? SaldoEstoque { get; set; }
        public int? TipoProdutoId { get; set; }
        public int? UnidadeMedidaId { get; set; }
        public double? ValorCompra { get; set; }
        public double? ValorVenda { get; set; }
        public double? ValorVendaPrazo { get; set; }
    }
}
