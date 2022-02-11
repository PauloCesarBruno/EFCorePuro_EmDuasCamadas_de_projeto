using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.DATA.Models
{
    public class RoupaEmprestimo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdRoupa { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório."),
        DataType(DataType.Date),
        Display(Name ="Data de Saida")]
        public DateTime DataEmprestimo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.Date),
        Display(Name = "Data de Retorno")]
        public DateTime DataEntrga { get; set; }

        public bool Entegue { get; set; }
    }
}
