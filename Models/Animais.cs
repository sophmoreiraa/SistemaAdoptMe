using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdoptMe.Models
{
    [Table("Animais")]
    public class Animais
    {
        [Column("AnimalId")]
        [Display(Name = "Id do Animal")]
        public int Id { get; set; }

        [Column("NomeAnimal")]
        [Display(Name = "Nome do Animal")]
        public string NomeAnimal { get; set; } = string.Empty;

        [Column("RacaAnimal")]
        [Display(Name = "Raça do Animal")]
        public string RacaAnimal { get; set; } = string.Empty;

        [Column("TipoAnimal")]
        [Display(Name = "Tipo do Animal")]
        public string TipoAnimal { get; set; } = string.Empty;


        [Column("CorAnimal")]
        [Display(Name = "Cor do Animal")]
        public string CorAnimal { get; set; } = string.Empty;


        [Column("SexoAnimal")]
        [Display(Name = "Sexo do Animal")]
        public string SexoAnimal { get; set; } = string.Empty;


        [Column("ObservacaoAnimal")]
        [Display(Name = "Observação do Animal")]
        public string ObservacaoAnimal { get; set; } = string.Empty;


        [Column("FotoAnimal")]
        [Display(Name = "Foto do Animal")]
        public string FotoAnimal { get; set; } = string.Empty;


        [Column("DtDesaparecimentoAnimal")]
        [Display(Name = "Data de Desaparecimento do Animal")]
        public DateTime DtDesaparecimentoAnimal { get; set; }

        [Column("DtEncontroAnimal")]
        [Display(Name = "Data de Encontro do Animal")]
        public DateTime? DtEncontroAnimal { get; set; }

        [Column("StatusAnimal")]
        [Display(Name = "Status do Animal")]
        public Byte StatusAnimal { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

    }
}
