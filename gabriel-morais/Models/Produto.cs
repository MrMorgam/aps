using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gabriel_morais.Models
{
    public class Produto
    {   
        [Display(Name = "Nome")]
        private string? nome { get; set; }
        [Display(Name = "Descrição")]
        private string? descricao { get; set; }
        [Display(Name = "Quantidade")]
        private int quantidade { get; set; }
        [Display(Name = "Preço")]
        private double preco { get; set; }
        private Item? item { get; set; }
    }
}