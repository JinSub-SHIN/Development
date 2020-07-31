using Microsoft.EntityFrameworkCore;
using C_Test.Models;

namespace C_Test.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options){

        }

        public DbSet<Todo> Movie {get; set;}
    }
}