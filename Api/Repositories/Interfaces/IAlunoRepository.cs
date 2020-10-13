﻿using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        public Task<IEnumerable<Aluno>> ListAsync();
    }
}
