using Api.Models;
using Api.Repositories.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.Repositories
{
    public class AlunoRepository : RepositoryBase, IAlunoRepository
    {
        IConfiguration _configuration;
        public AlunoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
              

        public async Task<IEnumerable<Aluno>> ListAsync()
        {
            //var connectionString = this.GetConnection();
            List<Aluno> alunos = new List<Aluno>();
            using (var con = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    con.Open();
                    var query = "SELECT * FROM Aluno";
                    alunos = con.Query<Aluno>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return alunos;
            }
        }
    }
}
