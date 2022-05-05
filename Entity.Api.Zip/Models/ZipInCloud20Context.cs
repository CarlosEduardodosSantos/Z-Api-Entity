using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entity.Api.Zip
{
    public partial class ZipInCloud20Context : DbContext
    {
        public ZipInCloud20Context()
        {
        }

        public ZipInCloud20Context(DbContextOptions<ZipInCloud20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Caixa1> Caixa1s { get; set; }
        public virtual DbSet<Caixa2> Caixa2s { get; set; }
        public virtual DbSet<Loja> Lojas { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Siemp> Siemps { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=zipsoftware2.ddns.com.br,33140;Database=ZipInCloud2.0;User ID=sa;Password=sql@adm;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Caixa1>(entity =>
            {
                entity.HasKey(e => e.NroCx);

                entity.ToTable("Caixa_1");

                entity.Property(e => e.NroCx)
                    .ValueGeneratedNever()
                    .HasColumnName("NroCX");

                entity.Property(e => e.ComandaFim).HasColumnName("Comanda_Fim");

                entity.Property(e => e.ComandaIni).HasColumnName("Comanda_Ini");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.DataF).HasColumnType("date");

                entity.Property(e => e.FimData)
                    .HasColumnType("date")
                    .HasColumnName("Fim_Data");

                entity.Property(e => e.FimHora)
                    .HasColumnType("datetime")
                    .HasColumnName("Fim_Hora");

                entity.Property(e => e.FimLoja).HasColumnName("Fim_Loja");

                entity.Property(e => e.FimUsuario)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Fim_Usuario");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Caixa2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAIXA_2");

                entity.Property(e => e.Esp1)
                    .HasColumnName("ESP1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Esp2)
                    .HasColumnName("ESP2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Esp3)
                    .HasColumnName("ESP3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Esp4)
                    .HasColumnName("ESP4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Esp5)
                    .HasColumnName("ESP5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Especie).HasColumnName("ESPECIE");

                entity.Property(e => e.FidPontos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("FID_PONTOS");

                entity.Property(e => e.Historico)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("HISTORICO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.NroLancCred).HasColumnName("nro_lanc_cred");

                entity.Property(e => e.NroPgto).HasColumnName("NRO_PGTO");

                entity.Property(e => e.Nrocob)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NROCOB");

                entity.Property(e => e.Nrocx).HasColumnName("NROCX");

                entity.Property(e => e.Nrovenda)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NROVENDA");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Venda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("venda")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Loja>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Obs)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Produtos__06370DADF82CCBD9");

                entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");

                entity.Property(e => e.Cest)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EAN");

                entity.Property(e => e.MarcaId).HasColumnName("MarcaID");

                entity.Property(e => e.NcmId).HasColumnName("NcmID");

                entity.Property(e => e.OrigemId).HasColumnName("OrigemID");

                entity.Property(e => e.ProdutoIntegracaoFiscalId).HasColumnName("ProdutoIntegracaoFiscalID");

                entity.Property(e => e.TipoProdutoId).HasColumnName("TipoProdutoID");

                entity.Property(e => e.UnidadeMedidaId).HasColumnName("UnidadeMedidaID");
            });

            modelBuilder.Entity<Siemp>(entity =>
            {
                entity.HasKey(e => e.Loja)
                    .HasName("PK__SIEMP__4E49AE9A106686E6");

                entity.ToTable("SIEMP");

                entity.Property(e => e.Loja).ValueGeneratedNever();

                entity.Property(e => e.AmbienteSat).HasColumnName("AmbienteSAT");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cnae)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNAE");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Cnpjrede)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJRede");

                entity.Property(e => e.CnpjsoftwareHouse)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNPJSoftwareHouse");

                entity.Property(e => e.CodAtivSat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CodAtivSAT");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.ContribuinteIpi).HasColumnName("ContribuinteIPI");

                entity.Property(e => e.ContribuinteSt).HasColumnName("ContribuinteST");

                entity.Property(e => e.Crt).HasColumnName("CRT");

                entity.Property(e => e.DesignerSat).HasColumnName("DesignerSAT");

                entity.Property(e => e.FabricanteSat).HasColumnName("FabricanteSAT");

                entity.Property(e => e.Fax)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GeraXmlsat).HasColumnName("GeraXMLSAT");

                entity.Property(e => e.Ie)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IE");

                entity.Property(e => e.Im)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("IM");

                entity.Property(e => e.Logradouro)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nfmod).HasColumnName("NFMod");

                entity.Property(e => e.Nfnro).HasColumnName("NFNro");

                entity.Property(e => e.Nfserie).HasColumnName("NFSerie");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Numero)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PercCredIcms)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("PercCredICMS");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.SignAcsat)
                    .IsUnicode(false)
                    .HasColumnName("SignACSAT");

                entity.Property(e => e.TipoExtratoSat).HasColumnName("TipoExtratoSAT");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .IsFixedLength(true);

                entity.Property(e => e.VersaoLayoutSat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VersaoLayoutSAT");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Acesso)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cpf)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataAtualizacao).HasColumnType("datetime");

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilUsuarioId).HasColumnName("PerfilUsuarioID");

                entity.Property(e => e.Senha)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
