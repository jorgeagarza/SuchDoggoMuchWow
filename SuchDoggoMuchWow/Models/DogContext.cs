using Microsoft.EntityFrameworkCore;
using SuchDoggoMuchWow.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuchDoggoMuchWow.Models
{
    public class DogContext : DbContext
    {
        public DogContext(DbContextOptions<DogContext> options) : base(options)
        {

        }

        public DbSet<Dog> Dogs { get; set; }
    }
}
