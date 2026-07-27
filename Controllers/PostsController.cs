using BlogManager_Tam.Models;
using Microsoft.AspNetCore.Mvc;

public class PostsController : Controller
{
    private static readonly List<Post> Posts =
    [
        new Post { Id = 1, Title = "C# cơ bản", Content = "Bài viết giới thiệu các kiến thức nền tảng về ngôn ngữ C#.", Author = "Tâm", ViewCount = 250, IsPublished = true },
        new Post { Id = 2, Title = "MVC nhập môn", Content = "Bài viết hướng dẫn cách tổ chức một ứng dụng theo mô hình MVC.", Author = "Hải", ViewCount = 150, IsPublished = false },
        new Post { Id = 3, Title = "EF Core", Content = "Bài viết tổng quan về Entity Framework Core và cách thao tác dữ liệu.", Author = "Hoàng", ViewCount = 100, IsPublished = true }
    ];

    public IActionResult Index() => View(Posts);

    public IActionResult Details(int id)
    {
        var post = Posts.FirstOrDefault(post => post.Id == id);
        return post is null ? NotFound() : View(post);
    }
}
