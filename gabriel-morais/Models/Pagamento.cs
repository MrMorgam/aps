using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gabriel_morais.Models
{
    public class Pagamento
    {
        [Display(Name = "Data Limite")]
        private date dataLimite { get; set; }
        [Display(Name = "Valor")]
        private double valor{ get; set; }
        [Display(Name = "Pago")]
        private bool pago { get; set; }
    }
}