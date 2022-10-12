using Microsoft.EntityFrameworkCore;
using StudentsAPI.Modals;

namespace StudentsAPI.Data
{
    public class StudentsAPIDBContext: DbContext
    {
     public StudentsAPIDBContext(DbContextOptions options) : base(options)
        {

        }


       public DbSet<Student> Students { get; set; }
    }
}
