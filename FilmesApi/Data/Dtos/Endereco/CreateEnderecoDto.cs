using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    public class CreateEnderecoDto
    {
        public string Logadouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
