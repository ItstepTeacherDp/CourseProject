using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public DatabaseContext() : base("myConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
    }

    class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext ctx)
        {
            Category category = new Category
            {
                Name = "Category 1",
                Goods = new List<Good>
                {
                    new Good { Name = "Good 1", Price = 22.5m },
                    new Good { Name = "Good 2", Price = 35.7m },
                }
            };
            ctx.Entry(category).State = EntityState.Added;
            ctx.SaveChanges();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var users = ctx.Categories.ToList();
                ;
            }
            Console.Read();
        }
    }
}
