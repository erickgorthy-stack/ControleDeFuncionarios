using ControleDeFuncionarios.Entities;
using ControleDeFuncionarios.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Controllers
{
    public class FuncionarioController
    {
        public void CadastrarFuncionario()
        {
            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIOS:\n");

            var funcionario = new Funcionario();

            Console.Write("INFORME O NOME DO FUNCIONÁRIO...: ");
            funcionario.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("INFORME O CPF...................: ");
            funcionario.Cpf = Console.ReadLine() ?? string.Empty;

            Console.Write("INFORME A DATA DE ADMISSÃO......: ");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("LOGRADOURO......................: ");
            funcionario.Endereco.Logradouro = Console.ReadLine() ?? string.Empty;

            Console.Write("NÚMERO..........................: ");
            funcionario.Endereco.Numero = Console.ReadLine() ?? string.Empty;

            Console.Write("COMPLEMENTO......................: ");
            funcionario.Endereco.Complemento = Console.ReadLine() ?? string.Empty;

            Console.Write("BAIRRO..........................: ");
            funcionario.Endereco.Bairro = Console.ReadLine() ?? string.Empty;

            Console.Write("CIDADE..........................: ");
            funcionario.Endereco.Cidade = Console.ReadLine() ?? string.Empty;

            Console.Write("ESTADO..........................: ");
            funcionario.Endereco.Estado = Console.ReadLine() ?? string.Empty;

            Console.Write("CEP.............................: ");
            funcionario.Endereco.Cep = Console.ReadLine() ?? string.Empty;

            //Salvar no banco de dados
            var funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.ExportarParaBancoDeDados(funcionario);

            Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!\n");
        }
    }
}
