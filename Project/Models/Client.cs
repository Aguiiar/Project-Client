using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Client
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O Tipo é obrigatório")]
        public string Type { get; set; }
        [Required(ErrorMessage = "O CPF/CNPJ é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$|^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "Digite um CPF/CNPJ Válido")]
        public string Document { get; set; }
        public DateTime DateRegistration { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [RegularExpression(@"^\(\d{2}\) \d{4,5}-\d{4}$", ErrorMessage = "Digite um telefone válido")]
        public string Phone { get; set; }

        public bool IsDeleted { get; set; }
    }
}