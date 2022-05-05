using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Api.Zip
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? EmpresaId { get; set; }
        public int? GrupoId { get; set; }
        public int? UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Acesso { get; set; }
        public bool? Ativo { get; set; }
        public int? PerfilUsuarioId { get; set; }
        public string Cpf { get; set; }
    }
}
