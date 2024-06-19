using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoptMe.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Id das Observações")]
        public int ObservacoesId { get; set; }

        [Column("DescricaoObservacao")]
        [Display(Name = "Descrição da Observação")]
        public string DescricaoObservacao { get; set; } = string.Empty;

        [Column("LocalObservacao")]
        [Display(Name = "Local da Observação")]
        public string LocalObservacao { get; set; } = string.Empty;

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        [ForeignKey("AnimaisId")]
        public int AnimaisId { get; set; }
        public Animais? Animais { get; set; }
    }
}
