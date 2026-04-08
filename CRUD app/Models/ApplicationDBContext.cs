using CRUD_app.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_app.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Constructor: when the app starts, it passes the database settings here
        //'options' contains connections string from the appsetting.json
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { } //pass options to the parent DbContext class

        //DbSet<Student> means : there is a table in your database by name of Students
        public DbSet<Student> Students { get; set; }
    }

}
