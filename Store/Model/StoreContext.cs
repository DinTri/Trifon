using Microsoft.EntityFrameworkCore;

namespace Store.Model
{
    public partial class StoreContext : DbContext
    {
        public StoreContext()
        {
        }

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stories> Stories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\Melissa;Database=Store;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stories>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Plot)
                    .HasColumnName("plot")
                    .HasMaxLength(500);

                entity.Property(e => e.Upvotes).HasColumnName("upvotes");

                entity.Property(e => e.Writer)
                    .HasColumnName("writer")
                    .HasMaxLength(50);
            });
        }
    }
}
