using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Entities
{
    public class Endereco
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Por favor, informe o logradouro.")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe o número.")]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe o complemento.")]
        public string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe o bairro.")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe a cidade.")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe o estado.")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe o CEP.")]
        public string Cep { get; set; } = string.Empty;
    }
}
