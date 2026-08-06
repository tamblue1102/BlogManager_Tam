using Microsoft.EntityFrameworkCore;
using BlogManager_Tam.Models;

namespace BlogManager_Tam.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Lập trình C#", PublishedAt = new DateTime(2026, 8, 1), IsPublished = true },
            new Category { Id = 2, Name = "ASP.NET MVC", PublishedAt = new DateTime(2026, 8, 2), IsPublished = true },
            new Category { Id = 3, Name = "Entity Framework Core", PublishedAt = new DateTime(2026, 8, 3), IsPublished = false },
            new Category { Id = 4, Name = "Lập trình web", PublishedAt = new DateTime(2026, 8, 4), IsPublished = true },
            new Category { Id = 5, Name = "Cơ sở dữ liệu", PublishedAt = new DateTime(2026, 8, 5), IsPublished = false },
            new Category { Id = 6, Name = "Tin tức công nghệ", PublishedAt = new DateTime(2026, 8, 6), IsPublished = true });

        modelBuilder.Entity<Post>().HasData(
            new Post
            {
                Id = 1,
                Title = "C# cơ bản",
                Content = "Bài viết giới thiệu các kiến thức nền tảng về ngôn ngữ C#.",
                PublishedAt = new DateTime(2026, 7, 30),
                IsPublished = true,
                Author = "Tâm",
                ViewCount = 250
            },
            new Post
            {
                Id = 2,
                Title = "MVC nhập môn",
                Content = "Bài viết hướng dẫn cách tổ chức một ứng dụng theo mô hình MVC.",
                PublishedAt = new DateTime(2026, 7, 30),
                IsPublished = false,
                Author = "Hải",
                ViewCount = 150
            },
            new Post
            {
                Id = 3,
                Title = "EF Core",
                Content = "Bài viết tổng quan về Entity Framework Core và cách thao tác dữ liệu.",
                PublishedAt = new DateTime(2026, 7, 30),
                IsPublished = true,
                Author = "Hoàng",
                ViewCount = 100
            });
    }
}
