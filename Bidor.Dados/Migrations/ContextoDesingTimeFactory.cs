using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidor.Dados.Migrations
{
    public class ContextoDesingTimeFactory : IDesignTimeDbContextFactory<Contexto>
    {
        private IConfiguration _configuration { get; set; }

        public ContextoDesingTimeFactory()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

        }
        public Contexto CreateDbContext(string[] args)
        {
            var dbContextOptions = new DbContextOptionsBuilder<Contexto>();
            dbContextOptions.UseSqlServer(_configuration.GetSection("ConnectionString:Contexto").Value);
            var contexto = new Contexto(dbContextOptions.Options);
            return contexto;
        }
    }
}
