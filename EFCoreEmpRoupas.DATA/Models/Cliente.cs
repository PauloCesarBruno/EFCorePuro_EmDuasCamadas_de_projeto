using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreEmpRoupas.DATA.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        MinLength(3, ErrorMessage = "Mínimo 03 (Três) caracteres."),
        MaxLength(100, ErrorMessage = "Máximo 100 (Cem) caracteres."),
        Display(Name = "Nome Cliente")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        MinLength(14, ErrorMessage = "Mínimo 14 (Quatorze) caracteres."),
        MaxLength(30, ErrorMessage = "Máximo 30 (Trinta) caracteres em caso de CNPJ."),
        Display(Name = "CPF/CNPJ")]
        public String CPF { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.PhoneNumber),
        Display(Name = "telefone")]
        public String Telefone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório."),
        DataType(DataType.EmailAddress),
        EmailAddress(ErrorMessage = "O Email não possui um formato Válido."),
        Display(Name = "E-Mail")]
        public String Email { get; set; }
    }
}
                                         