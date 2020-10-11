using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Incluir([FromBody] Aluno aluno)
        {
            return Ok(aluno);
        }
    }
}
