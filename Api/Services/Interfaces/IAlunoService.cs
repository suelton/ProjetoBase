﻿using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Interfaces
{
    public interface IAlunoService
    {
        public Task<Aluno> Incluir(Aluno aluno);
    }
}
