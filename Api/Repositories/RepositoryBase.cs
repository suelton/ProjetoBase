using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public class RepositoryBase
    {
        protected string GetConnectionString()
        {
            return $"Data Source={Environment.GetEnvironmentVariable("DATA_SOURCE")};Initial Catalog={Environment.GetEnvironmentVariable("DATA_BASE")};User ID=sa;Password={Environment.GetEnvironmentVariable("PASSWORD_DATABASE")}";
        }        
    }
}
