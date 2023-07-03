﻿using Microsoft.EntityFrameworkCore;
using Prototip.DBconnection.Entities;
using System.Configuration;

namespace Prototip.DBconnection
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public Context()
            : base()
        { }

        public DbSet<RescueEquipmentButton> RescueEquipmentButtons { get; set; }
        public DbSet<PPD> PPD { get; set; }
        public DbSet<PPDType> PPDType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString, ServerVersion.Parse("8.0.33"));
        }
    }

    public static class ContextManager
    {
        private static Context? context = null;

        public static Context GetContext()
        {
            if (context == null)
            {
                context = new Context();
            }

            return context;
        }
    }
}