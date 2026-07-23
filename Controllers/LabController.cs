using BlogManager_Tam.Models;
using Microsoft.AspNetCore.Mvc;


public class LabController : Controller
{
    public IActionResult Index()
    {
        var baiViet = new List<Post>
        {
            new Post { Id = 1, Title = "C# cơ bản",Author = "Tâm", ViewCount = 250, IsPublished = true },
            new Post { Id = 2, Title = "MVC nhập môn", Author = "Hải", ViewCount = 150, IsPublished = false },
            new Post { Id = 3, Title = "EF Core", Author = "Hoàng", ViewCount = 100, IsPublished = true },
            new Post { Id = 4, Title = "Lập trình LINQ", Author = "Cường", ViewCount = 220, IsPublished = true },
            new Post { Id = 5, Title = "ASP.NET Core Web API", Author = "Dũng", ViewCount = 50, IsPublished = false },
        };
        //Bài đã xuất bản, sắp xếp theo ViewCount giảm dần
        ViewBag.BaiVietDaXuatBan = baiViet
            .Where(p => p.IsPublished)
            .OrderByDescending(p => p.ViewCount)
            .ToList();
        //Tổng số lượt xem tất cả bài viết
        ViewBag.TongLuotXem = baiViet.Sum(p => p.ViewCount);

        //Bài viết có nhiều lượt xem nhất
        ViewBag.BaiVietHot = baiViet
            .OrderByDescending(p => p.ViewCount)
            .FirstOrDefault();
        return View();
    }
}