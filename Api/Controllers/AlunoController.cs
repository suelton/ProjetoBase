using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Api.Services.Interfaces;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService service;
        public AlunoController(IAlunoService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("incluir")]
        public async Task<IActionResult> Incluir([FromServices] IConfiguration config, [FromBody] Aluno aluno)
        {
            //using var conexao = new SqlConnection(config.GetConnectionString("ProjetoBase"));
            Aluno resultado = null;

            using (SqlConnection conexao = new SqlConnection(config.GetConnectionString("ProjetoBase")))
            {
                conexao.Open();
                resultado = conexao.QueryFirstOrDefault<Aluno>("SELECT * FROM dbo.Aluno ");
            }

            if (resultado != null)
                return Ok(resultado);
            else
            {
                return NotFound(
                    new
                    {
                        Mensagem = "Indicador inválido ou inexistente."
                    });
            }            
        }
    }
}
