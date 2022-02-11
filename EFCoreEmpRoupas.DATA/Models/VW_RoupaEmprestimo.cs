using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Models
{
    public class VW_RoupaEmprestimo
    {
        [Required(ErrorMessage = "Campo Obrigatório."),
        MinLength(3, ErrorMessage = "Mínimo 03 (Três) caracteres."),
        MaxLength(100, ErrorMessage = "Máximo 100 (Cem) caracteres."),
        Display(Name = "Nome Cliente")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        MinLength(5, ErrorMessage = "Mínimo 05 (Cinco) caracteres."),
        MaxLength(100, ErrorMessage = "Máximo 100 (Cem) caracteres."),
        Display(Name = "Roupa")]
        public String RoupaNome { get; set; }

        public int Id { get; set; }

        public int IdCliente { get; set; }

        public int IdRoupa { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.Date),
        Display(Name = "Data de Saida")]
        public DateTime DataEmprestimo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.Date),
        Display(Name = "Data de Retorno")]
        public DateTime DataEntrga { get; set; }

        [Display(Name = "Entregue")]
        public bool Entegue { get; set; }
    }
}
