using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gabriel_morais.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "Nome")]
        private date data { get; set; }
        [Display(Name = "Tipo")]
        private bool tipo { get; set; }
    }
}