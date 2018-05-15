using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuscarCepMVC.Models
{
    public class Cep
    {
        [Required]
        [MinLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        [MaxLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        public string Codigo { get; set; }
    }
}