using EFCoreEmpRoupas.DATA;
using EFCoreEmpRoupas.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Models
{
    public class EmprestimoViewModel
    {
        public int idCliente { get; set; }
        public Cliente oCliente { get; set; }

        public int idRoupa { get; set; }
        public Roupa oRoupa { get; set; }

        [Display(Name = "Retirada")]
        [DataType(DataType.Date)]
        public DateTime dataEmprestimo { get; set; }

        [Display(Name = "Devolução")]
        [DataType(DataType.Date)]
        public DateTime dataEntrega { get; set; }

        public List<Cliente> oListCliente { get; set; }

        public List<Roupa> oListLivro { get; set; }
    }
}
