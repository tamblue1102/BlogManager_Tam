using System.ComponentModel.DataAnnotations;

namespace BlogManager_Tam.Models;

public class Category
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập tên danh mục.")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    public DateTime PublishedAt { get; set; } = DateTime.Now;
    public bool IsPublished { get; set; }
}
