using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é Obrigatorio")]
        public string Nome { get; set; }
        public virtual List<Cinema> Cinemas { get; set; }
    }
}
