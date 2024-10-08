using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataBase
{
    public class DesignContext : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<Context>();
            options.UseNpgsql("Host=localhost;Port=5432;Database=WebApiSokol;Username=postgres;Password=123");
            return new Context(options.Options);

        }
    }
}
