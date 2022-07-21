using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OurWebSite.Models
{
    public class Date
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Date")] //definindo como o campo será exibido na view
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")] //o nome deve ser obrigatoriamente preenchido
        public string DateNome { get; set; }

        [DisplayName("Dia Chuvoso")]
        public bool DiaChuvoso { get; set; }

        [DisplayName("Dia Ensolarado")]
        public bool DiaEnsolarado { get; set; }
    }
}