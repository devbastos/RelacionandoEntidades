using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Controllers
{
    public class ReadEnderecoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logadouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
