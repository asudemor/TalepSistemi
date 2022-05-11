using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalepSistemi.Models;

namespace TalepSistemi.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DbTalepSistemi;intregrated security=true;");
        //}


        public DbSet<Talep> Talepler { get; set; } 
    }
}
