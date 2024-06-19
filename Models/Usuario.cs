using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoptMe.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Id do Usuário")]
        public int Id { get; set; }

        [Column("NomeUsuario")]
        [Display(Name = "Nome do Usuário")]
        public string NomeUsuario { get; set; } = string.Empty;

        [Column("TelefoneUsuario")]
        [Display(Name = "Telefone do Usuário")]
        public string TelefoneUsuario { get; set; } = string.Empty;

        [Column("EmailUsuario")]
        [Display(Name = "Email do Usuário")]
        public string EmailUsuario { get; set; } = string.Empty;

        [Column("SenhaUsuario")]
        [Display(Name = "Email do Usuário")]
        public string SenhaUsuario { get; set; } = string.Empty;

    }
}
