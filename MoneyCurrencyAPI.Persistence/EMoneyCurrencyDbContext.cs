using Microsoft.EntityFrameworkCore;
using MoneyCurrencyAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCurrencyAPI.Persistence
{
    public class EMoneyCurrencyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MoneyCurrency;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Currency> Currencies { get; set; }
    }
}

