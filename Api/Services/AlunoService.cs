using Api.Models;
using Api.Repositories;
using Api.Repositories.Interfaces;
using Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository repository;

        public AlunoService(IAlunoRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Aluno>> ListAsync()
        {
            return await repository.ListAsync();
        }
    }
}
