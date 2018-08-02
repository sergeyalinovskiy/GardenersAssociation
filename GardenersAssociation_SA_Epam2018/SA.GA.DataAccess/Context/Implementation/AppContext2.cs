using Microsoft.EntityFrameworkCore;
using SA.GA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.GA.DataAccess.Context.Implementation
{
    public class AppContext2 : DbContext
    {

        public AppContext2(DbContextOptions<AppContext2> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SA.GA.DB4;Trusted_Connection=True;");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<History> Historys { get; set; }
        public DbSet<Electricity> Electricitys { get; set; }


    }
}
