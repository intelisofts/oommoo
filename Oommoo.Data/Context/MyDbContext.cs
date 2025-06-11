using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Oommoo.Data.Entities;
using File = Oommoo.Data.Entities.File;

namespace Oommoo.Data.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<ProductionCompany> ProductionCompanies { get; set; }

    public virtual DbSet<ProductionCompanyUser> ProductionCompanyUsers { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<ShowUser> ShowUsers { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }

    public virtual DbSet<VenueEvent> VenueEvents { get; set; }

    public virtual DbSet<VenueShow> VenueShows { get; set; }

    public virtual DbSet<VenueUser> VenueUsers { get; set; }

    public virtual DbSet<Watchlist> Watchlists { get; set; }

    public virtual DbSet<WatchlistItem> WatchlistItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=oommoo_ef;User Id=root;Password=Foxter20!8");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("activity");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Request).HasColumnName("request");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contact");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Address2)
                .HasColumnType("text")
                .HasColumnName("address2");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("country");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EntityId)
                .HasMaxLength(45)
                .HasColumnName("entity_id");
            entity.Property(e => e.EntityType)
                .HasColumnType("enum('USER','PRODUCTION_COMPANY','VENUE','SHOW','EVENT')")
                .HasColumnName("entity_type");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.Phone2)
                .HasMaxLength(255)
                .HasColumnName("phone2");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(255)
                .HasColumnName("postal_code");
            entity.Property(e => e.Primary).HasColumnName("primary");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("event");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("file");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.EntityId)
                .HasMaxLength(45)
                .HasColumnName("entity_id");
            entity.Property(e => e.EntityType)
                .HasColumnType("enum('USER','PRODUCTION_COMPANY','VENUE','SHOW','EVENT','REVIEW','WATCHLIST','WATCHLIST_ITEM')")
                .HasColumnName("entity_type");
            entity.Property(e => e.Filename)
                .HasColumnType("text")
                .HasColumnName("filename");
            entity.Property(e => e.Filetype)
                .HasColumnType("text")
                .HasColumnName("filetype");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Path)
                .HasColumnType("text")
                .HasColumnName("path");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.Url)
                .HasColumnType("text")
                .HasColumnName("url");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("like");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.EntityId)
                .HasMaxLength(45)
                .HasColumnName("entity_id");
            entity.Property(e => e.EntityType)
                .HasColumnType("enum('USER','PRODUCTION_COMPANY','PRODUCTION_COMPANY_USER','VENUE','SHOW','EVENT','REVIEW','WATCHLIST')")
                .HasColumnName("entity_type");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.Value)
                .HasMaxLength(1)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ProductionCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("production_company");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.Founded)
                .HasColumnType("datetime")
                .HasColumnName("founded");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ProductionCompanyUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("production_company_user");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ProductionCompanyId)
                .HasMaxLength(45)
                .HasColumnName("production_company_id");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rating");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.EventId)
                .HasMaxLength(45)
                .HasColumnName("event_id");
            entity.Property(e => e.Held).HasColumnName("held");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ReviewId)
                .HasMaxLength(45)
                .HasColumnName("review_id");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.ShowUserId)
                .HasMaxLength(45)
                .HasColumnName("show_user_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.VenueId)
                .HasMaxLength(45)
                .HasColumnName("venue_id");
            entity.Property(e => e.VenueShowId)
                .HasMaxLength(45)
                .HasColumnName("venue_show_id");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("review");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.EventId)
                .HasMaxLength(45)
                .HasColumnName("event_id");
            entity.Property(e => e.Held).HasColumnName("held");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.Review1).HasColumnName("review");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.ShowUserId)
                .HasMaxLength(45)
                .HasColumnName("show_user_id");
            entity.Property(e => e.Type)
                .HasColumnType("enum('AUDIENCE','CRITIC')")
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
            entity.Property(e => e.VenueId)
                .HasMaxLength(45)
                .HasColumnName("venue_id");
            entity.Property(e => e.VenueShowId)
                .HasMaxLength(45)
                .HasColumnName("venue_show_id");
        });

        modelBuilder.Entity<Show>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("show");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.AgeRecommendation)
                .HasMaxLength(255)
                .HasColumnName("age_recommendation");
            entity.Property(e => e.AverageRating).HasColumnName("average_rating");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.Duration)
                .HasMaxLength(255)
                .HasColumnName("duration");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ProductionCompanyId)
                .HasMaxLength(45)
                .HasColumnName("production_company_id");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasColumnType("enum('THEATRE','DANCE','PERFORMANCE_ART','MUSIC')")
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<ShowUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("show_user");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.AttendanceType)
                .HasColumnType("enum('VENUE','PRODUCTION','CAST','CREW','CRITIC','AUDIENCE')")
                .HasColumnName("attendance_type");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
            entity.Property(e => e.VenueShowId)
                .HasMaxLength(45)
                .HasColumnName("venue_show_id");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tag");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.EntityId)
                .HasMaxLength(45)
                .HasColumnName("entity_id");
            entity.Property(e => e.EntityType)
                .HasColumnType("enum('USER','PRODUCTION_COMPANY','PRODUCTION_COMPANY_USER','VENUE','SHOW','EVENT','REVIEW','WATCHLIST')")
                .HasColumnName("entity_type");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.Tag1)
                .HasColumnType("text")
                .HasColumnName("tag");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.LoggedIn).HasColumnName("logged_in");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("middle_name");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ResetCode)
                .HasMaxLength(255)
                .HasColumnName("reset_code");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.Subtype)
                .HasMaxLength(255)
                .HasColumnName("subtype");
            entity.Property(e => e.SystemId)
                .HasMaxLength(255)
                .HasColumnName("system_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
            entity.Property(e => e.VerificationCode)
                .HasMaxLength(255)
                .HasColumnName("verification_code");
            entity.Property(e => e.VerificationType)
                .HasMaxLength(255)
                .HasColumnName("verification_type");
            entity.Property(e => e.Verified).HasColumnName("verified");
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user_permission");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.EntityId)
                .HasMaxLength(45)
                .HasColumnName("entity_id");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("enum('ADD_SHOW','EDIT_SHOW','ADD_USER','EDIT_USER','ADD_VENUE','EDIT_VENUE','ADD_REVIEW','EDIT_REVIEW','ADD_RATING','EDIT_RATING','ADD_EVENT','EDIT_EVENT','ADD_PRODUCTION_COMPANY','EDIT_PRODUCTION_COMPANY')")
                .HasColumnName("name");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Venue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venue");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.Accessibility)
                .HasMaxLength(255)
                .HasColumnName("accessibility");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");

            entity.Property(e => e.Capacity).HasColumnName("capacity").HasMaxLength(255);
            entity.Property(e => e.VenueAddress).HasColumnName("venue_address").HasMaxLength(255);
            entity.Property(e => e.Location).HasColumnName("location").HasMaxLength(255);
            entity.Property(e => e.CurrentManagement).HasColumnName("current_management").HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number").HasMaxLength(255);
            entity.Property(e => e.OpenedOn).HasColumnName("opened_on").HasMaxLength(255);
            entity.Property(e => e.Stagedoor).HasColumnName("stage_door").HasMaxLength(255);
            entity.Property(e => e.ShowScore).HasColumnName("show_score").HasMaxLength(255);
        });

        modelBuilder.Entity<VenueEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venue_event");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EventId)
                .HasMaxLength(45)
                .HasColumnName("event_id");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.VenueId)
                .HasMaxLength(45)
                .HasColumnName("venue_id");
        });

        modelBuilder.Entity<VenueShow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venue_show");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EndTime)
                .HasMaxLength(255)
                .HasColumnName("end_time");
            entity.Property(e => e.EventId)
                .HasMaxLength(45)
                .HasColumnName("event_id");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.StartTime)
                .HasMaxLength(255)
                .HasColumnName("start_time");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.VenueEventId)
                .HasMaxLength(45)
                .HasColumnName("venue_event_id");
            entity.Property(e => e.VenueId)
                .HasMaxLength(45)
                .HasColumnName("venue_id");
        });

        modelBuilder.Entity<VenueUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("venue_user");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.Type)
                .HasColumnType("text")
                .HasColumnName("type");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
            entity.Property(e => e.VenueId)
                .HasMaxLength(45)
                .HasColumnName("venue_id");
        });

        modelBuilder.Entity<Watchlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("watchlist");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DisplayImageUrl)
                .HasColumnType("text")
                .HasColumnName("display_image_url");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasColumnType("text")
                .HasColumnName("name");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(45)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<WatchlistItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("watchlist_item");

            entity.HasIndex(e => e.Id, "id_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(45)
                .HasColumnName("id");
            entity.Property(e => e.CreateTime)
                .HasColumnType("datetime")
                .HasColumnName("create_time");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(45)
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasMaxLength(1)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Private).HasColumnName("private");
            entity.Property(e => e.ShowId)
                .HasMaxLength(45)
                .HasColumnName("show_id");
            entity.Property(e => e.UpdateTime)
                .HasColumnType("datetime")
                .HasColumnName("update_time");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(45)
                .HasColumnName("updated_by");
            entity.Property(e => e.WatchlistId)
                .HasMaxLength(45)
                .HasColumnName("watchlist_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
