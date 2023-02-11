using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinalProject.API.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutu> Aboutus { get; set; }
        public virtual DbSet<Bankaccount> Bankaccounts { get; set; }
        public virtual DbSet<Cahrity> Cahrities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contactu> Contactus { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Homepage> Homepages { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=JOR_FP2;PASSWORD=Test321;DATA SOURCE= 94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR_FP2")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Aboutu>(entity =>
            {
                entity.HasKey(e => e.Aboutid)
                    .HasName("SYS_C00310577");

                entity.ToTable("ABOUTUS");

                entity.Property(e => e.Aboutid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUTID");

                entity.Property(e => e.Imagepath1)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH1");

                entity.Property(e => e.Imagepath2)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH2");

                entity.Property(e => e.Paraghraph1)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PARAGHRAPH1");

                entity.Property(e => e.Paraghraph2)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PARAGHRAPH2");
            });

            modelBuilder.Entity<Bankaccount>(entity =>
            {
                entity.HasKey(e => e.Accountid)
                    .HasName("SYS_C00310571");

                entity.ToTable("BANKACCOUNT");

                entity.Property(e => e.Accountid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Balance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.Expireddate)
                    .HasColumnType("DATE")
                    .HasColumnName("EXPIREDDATE");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");
            });

            modelBuilder.Entity<Cahrity>(entity =>
            {
                entity.HasKey(e => e.Charityid)
                    .HasName("SYS_C00310560");

                entity.ToTable("CAHRITY");

                entity.Property(e => e.Charityid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CHARITYID");

                entity.Property(e => e.Balance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.CategoryidFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORYID_FK");

                entity.Property(e => e.Charityname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHARITYNAME");

                entity.Property(e => e.DocidFk)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DOCID_FK");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Goal)
                    .HasColumnType("NUMBER")
                    .HasColumnName("GOAL");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Isaccepted)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ISACCEPTED");

                entity.Property(e => e.Numdonation)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMDONATION");

                entity.Property(e => e.State)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STATE");

                entity.Property(e => e.UseridFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID_FK");

                entity.HasOne(d => d.CategoryidFkNavigation)
                    .WithMany(p => p.Cahrities)
                    .HasForeignKey(d => d.CategoryidFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("CATEGORYID_FK");

                entity.HasOne(d => d.UseridFkNavigation)
                    .WithMany(p => p.Cahrities)
                    .HasForeignKey(d => d.UseridFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERID_FK1");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_DESC");

                entity.Property(e => e.CategoryParagraph)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_PARAGRAPH");

                entity.Property(e => e.Categoryimage)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYIMAGE");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYNAME");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.Contactid)
                    .HasName("SYS_C00310581");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Contactid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Msg)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("MSG");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Subject)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.Docid)
                    .HasName("SYS_C00310564");

                entity.ToTable("DOCUMENTS");

                entity.Property(e => e.Docid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DOCID");

                entity.Property(e => e.CharityidFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARITYID_FK");

                entity.Property(e => e.Doc)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DOC");

                entity.Property(e => e.Docname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DOCNAME");

                entity.Property(e => e.UseridFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID_FK");

                entity.HasOne(d => d.CharityidFkNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CharityidFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("CHARITYID_FK");

                entity.HasOne(d => d.UseridFkNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.UseridFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERID_FK2");
            });

            modelBuilder.Entity<Donation>(entity =>
            {
                entity.ToTable("DONATION");

                entity.Property(e => e.Donationid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DONATIONID");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Charityfk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CHARITYFK");

                entity.Property(e => e.Datedonation)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEDONATION");

                entity.Property(e => e.Userfk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERFK");

                entity.HasOne(d => d.CharityfkNavigation)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.Charityfk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CHARITY11");

                entity.HasOne(d => d.UserfkNavigation)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.Userfk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_USER11");
            });

            modelBuilder.Entity<Homepage>(entity =>
            {
                entity.HasKey(e => e.Homeid)
                    .HasName("SYS_C00310579");

                entity.ToTable("HOMEPAGE");

                entity.Property(e => e.Homeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOMEID");

                entity.Property(e => e.Imagepath1)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH1");

                entity.Property(e => e.Imagepath2)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH2");

                entity.Property(e => e.Paraghraph1)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PARAGHRAPH1");

                entity.Property(e => e.Paraghraph2)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PARAGHRAPH2");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("REPORT");

                entity.Property(e => e.Reportid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REPORTID");

                entity.Property(e => e.Dateofreport)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEOFREPORT");

                entity.Property(e => e.Numberofbenificiaries)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBEROFBENIFICIARIES");

                entity.Property(e => e.Numberofdonations)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBEROFDONATIONS");

                entity.Property(e => e.Numberofdoners)
                    .HasColumnType("NUMBER")
                    .HasColumnName("NUMBEROFDONERS");

                entity.Property(e => e.Totaldonations)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALDONATIONS");

                entity.Property(e => e.Totalusers)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALUSERS");

                entity.Property(e => e.UseridFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID_FK");

                entity.HasOne(d => d.UseridFkNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UseridFk)
                    .HasConstraintName("USERID_FKKK");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Testimonialid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIALID");

                entity.Property(e => e.Isaccept)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ISACCEPT");

                entity.Property(e => e.Paragraph)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH");

                entity.Property(e => e.Rate)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RATE");

                entity.Property(e => e.UseridFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID_FK");

                entity.HasOne(d => d.UseridFkNavigation)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.UseridFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERID_FK3");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(455)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Isaccepted)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ISACCEPTED");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Roleidfk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEIDFK");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.RoleidfkNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Roleidfk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ROLEID_FK");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("WALLETS");

                entity.Property(e => e.Walletid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("WALLETID");

                entity.Property(e => e.Balance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.BankaccountFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BANKACCOUNT_FK");

                entity.Property(e => e.UseridFk)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID_FK");

                entity.HasOne(d => d.BankaccountFkNavigation)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.BankaccountFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("BANK_FK");

                entity.HasOne(d => d.UseridFkNavigation)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.UseridFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("USERID_FK4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
