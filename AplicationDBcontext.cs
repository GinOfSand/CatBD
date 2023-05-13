using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatBD
{
    internal class ApplicationDBcontext:DbContext
    {
        public DbSet<Famyly> famylies { get; set; } = null!;
        public DbSet<InformationAboutTheBreed> infoAboutTheBreeds { get; set; } = null!;
        public DbSet<BreedCharacteristics> breedCharacteristics { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=drona.db.elephantsql.com;Port=5432;Database=nehwwwyw;Username=nehwwwyw;Password=sMPEvqJgX_F5M6kv2BVDrV-8w6Iebq4u");
        }
        //"Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=123456789"

    }
}
