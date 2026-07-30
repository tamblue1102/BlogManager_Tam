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
