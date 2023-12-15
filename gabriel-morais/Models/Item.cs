using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gabriel_morais.Models
{
    public class Item
    {
        [Display(Name = "Preço")]
        private double preco { get; set; }
        [Display(Name = "Percentual")]
        private int percentual { get; set; }
        [Display(Name = "Quantidade")]
        private int quantidade { get; set; }
    }
}