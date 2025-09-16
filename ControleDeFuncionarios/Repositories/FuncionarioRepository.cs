using ControleDeFuncionarios.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarParaBancoDeDados(Funcionario funcionario)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDFuncionarios;Integrated Security=True";
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("SP_INSERIR_FUNCIONARIO", new
                {
                    @NOME = funcionario.Nome,
                    @CPF = funcionario.Cpf,
                    @DATAADMISSAO = funcionario.DataAdmissao,
                    @LOGRADOURO = funcionario.Endereco.Logradouro,
                    @NUMERO = funcionario.Endereco.Numero,
                    @COMPLEMENTO = funcionario.Endereco.Complemento,
                    @BAIRRO = funcionario.Endereco.Bairro,
                    @CIDADE = funcionario.Endereco.Cidade,
                    @ESTADO = funcionario.Endereco.Estado,
                    @CEP = funcionario.Endereco.Cep
                },
                commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void ExportarParaJson()
        {

        }
    }
}
