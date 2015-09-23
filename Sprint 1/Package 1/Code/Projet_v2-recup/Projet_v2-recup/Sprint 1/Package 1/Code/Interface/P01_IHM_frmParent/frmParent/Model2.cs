namespace frmParent
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<colors> colors { get; set; }
        public virtual DbSet<messages> messages { get; set; }
        public virtual DbSet<pieces> pieces { get; set; }
        public virtual DbSet<pieces_users> pieces_users { get; set; }
        public virtual DbSet<sets> sets { get; set; }
        public virtual DbSet<sets_pieces> sets_pieces { get; set; }
        public virtual DbSet<sets_users> sets_users { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<colors>()
                .Property(e => e.descr)
                .IsUnicode(false);

            modelBuilder.Entity<colors>()
                .HasMany(e => e.sets_pieces)
                .WithRequired(e => e.colors)
                .HasForeignKey(e => e.color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.message_id)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.receiver)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.sets_id)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<pieces>()
                .Property(e => e.piece_id)
                .IsUnicode(false);

            modelBuilder.Entity<pieces>()
                .Property(e => e.descr)
                .IsUnicode(false);

            modelBuilder.Entity<pieces>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<pieces>()
                .HasMany(e => e.pieces_users)
                .WithRequired(e => e.pieces)
                .HasForeignKey(e => e.pieces_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pieces>()
                .HasMany(e => e.sets_pieces)
                .WithRequired(e => e.pieces)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pieces_users>()
                .Property(e => e.pieces_id)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .Property(e => e.sets_id)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .Property(e => e.pieces)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .Property(e => e.t1)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .Property(e => e.descr)
                .IsUnicode(false);

            modelBuilder.Entity<sets>()
                .HasMany(e => e.sets_users)
                .WithRequired(e => e.sets)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sets>()
                .HasMany(e => e.sets_pieces)
                .WithRequired(e => e.sets)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sets_pieces>()
                .Property(e => e.sets_id)
                .IsUnicode(false);

            modelBuilder.Entity<sets_pieces>()
                .Property(e => e.piece_id)
                .IsUnicode(false);

            modelBuilder.Entity<sets_users>()
                .Property(e => e.sets_id)
                .IsUnicode(false);

            modelBuilder.Entity<sets_users>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.messages)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.addresser);

            modelBuilder.Entity<users>()
                .HasMany(e => e.pieces_users)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.sets_users)
                .WithRequired(e => e.users)
                .WillCascadeOnDelete(false);
        }
    }
}
