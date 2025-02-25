using System.Data.Entity;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public Microsoft.EntityFrameworkCore.DbSet<Actor> Actors { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cinema> Cinemas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Movie> Movies { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Producer> Producers { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}
