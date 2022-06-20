using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project.Models
{
    public partial class FAP_ProjectContext : DbContext
    {
        public FAP_ProjectContext()
        {
        }

        public FAP_ProjectContext(DbContextOptions<FAP_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationType> ApplicationTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Folk> Folks { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                String conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                optionsBuilder.UseSqlServer(conn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.File).HasMaxLength(512);

                entity.Property(e => e.Note).HasColumnType("ntext");

                entity.Property(e => e.Purpose).HasColumnType("ntext");

                entity.Property(e => e.Status).HasDefaultValueSql("((2))");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK__Applicati__Stude__48CFD27E");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Applicati__TypeI__47DBAE45");
            });

            modelBuilder.Entity<ApplicationType>(entity =>
            {
                entity.ToTable("ApplicationType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.HasOne(d => d.ProvinceNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.Province)
                    .HasConstraintName("FK__City__Province__4E88ABD4");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(64);

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK__District__City__5165187F");
            });

            modelBuilder.Entity<Folk>(entity =>
            {
                entity.ToTable("Folk");

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(64);

                entity.Property(e => e.Role).HasDefaultValueSql("((0))");

                entity.Property(e => e.RollNumber).HasMaxLength(32);

                entity.HasOne(d => d.StaffNavigation)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Staff)
                    .HasConstraintName("FK__Login__Staff__44FF419A");

                entity.HasOne(d => d.StudentNavigation)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Student)
                    .HasConstraintName("FK__Login__Student__440B1D61");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("Religion");

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasColumnType("ntext");

                entity.Property(e => e.Avatar).HasMaxLength(256);

                entity.Property(e => e.Born).HasMaxLength(128);

                entity.Property(e => e.Capstone).HasMaxLength(128);

                entity.Property(e => e.ChangeCity).HasMaxLength(128);

                entity.Property(e => e.ChangeMajorConfirm).HasMaxLength(128);

                entity.Property(e => e.CurrentTerm).HasMaxLength(32);

                entity.Property(e => e.Curriculumn).HasMaxLength(128);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Doi)
                    .HasColumnType("date")
                    .HasColumnName("DOI");

                entity.Property(e => e.DropConfirm).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.EnrollDate).HasColumnType("date");

                entity.Property(e => e.Financial)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.FinancialType).HasMaxLength(128);

                entity.Property(e => e.Fullname).HasMaxLength(256);

                entity.Property(e => e.Identity).HasMaxLength(32);

                entity.Property(e => e.MainClass).HasMaxLength(128);

                entity.Property(e => e.Major).HasMaxLength(128);

                entity.Property(e => e.MemberCode).HasMaxLength(32);

                entity.Property(e => e.Mode).HasMaxLength(128);

                entity.Property(e => e.OldId)
                    .HasMaxLength(32)
                    .HasColumnName("OldID");

                entity.Property(e => e.OldMajor).HasMaxLength(128);

                entity.Property(e => e.ParentAddress).HasColumnType("ntext");

                entity.Property(e => e.ParentEmail).HasMaxLength(256);

                entity.Property(e => e.ParentJob).HasMaxLength(128);

                entity.Property(e => e.ParentName).HasMaxLength(256);

                entity.Property(e => e.ParentPhone).HasMaxLength(32);

                entity.Property(e => e.ParentPow)
                    .HasMaxLength(256)
                    .HasColumnName("ParentPOW");

                entity.Property(e => e.Phonenumber).HasMaxLength(32);

                entity.Property(e => e.Poi)
                    .HasMaxLength(128)
                    .HasColumnName("POI");

                entity.Property(e => e.PreparedSvconfirm)
                    .HasMaxLength(128)
                    .HasColumnName("PreparedSVConfirm");

                entity.Property(e => e.RealAddress).HasMaxLength(64);

                entity.Property(e => e.RejoinConfirm).HasMaxLength(128);

                entity.Property(e => e.SevenYear).HasMaxLength(32);

                entity.Property(e => e.Specialize).HasMaxLength(32);

                entity.Property(e => e.Status).HasMaxLength(128);

                entity.Property(e => e.SuspendConfirm).HasMaxLength(128);

                entity.Property(e => e.Svcqconfirm)
                    .HasMaxLength(128)
                    .HasColumnName("SVCQConfirm");

                entity.Property(e => e.Svcqdate)
                    .HasColumnType("date")
                    .HasColumnName("SVCQDate");

                entity.Property(e => e.Tnconfirm)
                    .HasMaxLength(128)
                    .HasColumnName("TNConfirm");

                entity.Property(e => e.Ttto)
                    .HasMaxLength(32)
                    .HasColumnName("TTto");

                entity.HasOne(d => d.FolkNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Folk)
                    .HasConstraintName("FK__Student__Folk__3C69FB99");

                entity.HasOne(d => d.ReligionNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Religion)
                    .HasConstraintName("FK__Student__Religio__3D5E1FD2");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.Fullname).HasMaxLength(256);

                entity.Property(e => e.Phonenumber).HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
