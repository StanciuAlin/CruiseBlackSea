namespace CruiseBlackSea
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LogInModel : DbContext
    {
        public LogInModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Cruise> Cruises { get; set; }
        public virtual DbSet<Harbour> Harbours { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.address_user)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.email_address)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.password_user)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.user_name_app)
                .IsUnicode(false);

            modelBuilder.Entity<Cruise>()
                .Property(e => e.harbour_list)
                .IsUnicode(false);

            modelBuilder.Entity<Harbour>()
                .Property(e => e.harbour_name)
                .IsUnicode(false);
        }
    }
}
