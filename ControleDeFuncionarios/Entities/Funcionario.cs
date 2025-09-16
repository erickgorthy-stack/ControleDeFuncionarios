using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Entities
{
    public class Funcionario
    {
        [MinLength(8, ErrorMessage = "Informe o nome com pelo menos {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome.")]
        public string Nome { get; set; } = string.Empty;

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Informe o cpf com exatamente 11 caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o CPF.")]
        public string Cpf { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor, informe a data de nascimento.")]
        public DateTime DataAdmissao { get; set; }


        #region Relacionamentos

        public Endereco Endereco { get; set; } = new();

        #endregion
    }
}
