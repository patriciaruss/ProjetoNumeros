using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class NumeroViewModel
    {
        public string ResultadoSortudo { get; set; }
        public string ResultadoFeliz { get; set; }
        [Required(ErrorMessage = "Número � obrigat�rio")]
        public long Numero { get; set; }
    }
}