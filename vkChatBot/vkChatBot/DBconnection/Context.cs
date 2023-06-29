using Microsoft.EntityFrameworkCore;
using vkChatBot.DBconnection.Entities;
using System.Configuration;

namespace vkChatBot.DBconnection
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public Context()
            : base()
        { }

        public DbSet<BotUser> BotUsers { get; set; }
        public DbSet<PostIsCallSign> PostIsCallSign { get; set; }
        public DbSet<BotSourceGroup> BotSourceGroups { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

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
