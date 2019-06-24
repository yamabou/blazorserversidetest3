using Microsoft.EntityFrameworkCore;

namespace blazorserversidetest3.Models
{
    public class MyContext : DbContext
    {

        public MyContext() {
            
        }
        // コンストラクタ
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Book> Book {get; set;}

        public DbSet<Configs> Configs {get; set;}

        public DbSet<RetData> RetData {get; set;}
    }
}