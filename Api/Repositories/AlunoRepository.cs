﻿using Api.Models;
using Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        public async Task<IEnumerable<Aluno>> ListAsync()
        {
            return null;
        }
    }
}
