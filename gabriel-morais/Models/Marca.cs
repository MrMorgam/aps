using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gabriel_morais.Models
{
    public class Marca
    {   
        [Display(Name = "Nome")]
        private string? nome { get; set; }
        [Display(Name = "Descrição")]
        private string? descricao { get; set; }
        private Produto? produto { get; set; }
    }
}