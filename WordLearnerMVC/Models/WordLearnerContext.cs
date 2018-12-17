namespace WordLearnerMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WordLearnerContext : DbContext
    {
        public WordLearnerContext()
            : base("name=WordLearnerDbModel")
        {
        }

        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<WordType> WordTypes { get; set; }
        public virtual DbSet<PracticeRecord> Practices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageName)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Translations)
                .WithRequired(e => e.Language)
                .HasForeignKey(e => e.LanguageTranslation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Language)
                .HasForeignKey(e => e.DefDestinationLanguageID);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.Language1)
                .HasForeignKey(e => e.DefSourceLanguageID);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Words)
                .WithRequired(e => e.Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Translation>()
                .Property(e => e.Meaning)
                .IsUnicode(false);

            modelBuilder.Entity<Translation>()
                .Property(e => e.LanguageTranslation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.DefSourceLanguageID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.DefDestinationLanguageID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Practices)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Word>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Word>()
                .Property(e => e.LanguageID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Word>()
                .HasMany(e => e.Translations)
                .WithRequired(e => e.Word)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WordType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WordType>()
                .HasMany(e => e.Words)
                .WithRequired(e => e.WordType)
                .WillCascadeOnDelete(false);
        }
    }
}
