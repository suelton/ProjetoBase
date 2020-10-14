using Api.Models;
using Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    /// <summary>
    /// Controller para tratar os alunos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService service;

        public AlunoController(IAlunoService service)
        {
            this.service = service;
        }
                
        [HttpGet]
        [Route("list")]
        public async Task<IEnumerable<Aluno>> ListAsync()
        {
            return await service.ListAsync();            
        }
    }
}
