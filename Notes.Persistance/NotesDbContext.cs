using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Persistance.EntityTypeConfigurations;
using Notes.Domain;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(Builder);
        }
    }
}
