using Microsoft.EntityFrameworkCore;
using CRUD_app.Models;

namespace CRUD_app.Models
{
    public class ApplicationDBContext : DbContext
    {
        //Constructor: when the app starts, it passes the database settings here
        //'options' contains connections string from the appsetting.json
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { } //pass options to the parent DbContext class

        //DbSet<Student> means : there is a table in your database by name of Students
        public DbSet<Students> Students { get; set; }

        public DbSet<Teacher> Teacher { get; set; }
    }

}
