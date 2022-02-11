using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.DATA
{
    public class Roupa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
         MinLength(5, ErrorMessage = "Mínimo 05 (Cinco) caracteres."),
         MaxLength(100, ErrorMessage = "Máximo 100 (Cem) caracteres."),
         Display(Name = "Roupa")]
        public String RoupaNome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        MinLength(10, ErrorMessage = "Mínimo 10 (Dez) caracteres."),
        MaxLength(200, ErrorMessage = "Máximo 200 (Duzentos) caracteres."),
        Display(Name = "Descrição")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.Currency),
        Display(Name = "Valor da Locação")]
        public Decimal? ValorLocacao { get; set; }
    }
}
