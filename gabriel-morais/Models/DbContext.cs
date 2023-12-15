using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace gabriel_morais.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Produto> Produto {get; set;}
       public DbSet<Item> Item {get; set;}
       public DbSet<Marca> Marca {get; set;}
   }
}
