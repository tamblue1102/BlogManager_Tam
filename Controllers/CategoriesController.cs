using BlogManager_Tam.Data;
using BlogManager_Tam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class CategoriesController : Controller
{
    private readonly ApplicationDbContext _context;

    public CategoriesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string? search, int page = 1)
    {
        const int pageSize = 5;
        var categoriesQuery = _context.Categories.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            categoriesQuery = categoriesQuery.Where(category => category.Name.Contains(search));
        }

        var totalCategories = await categoriesQuery.CountAsync();
        var totalPages = Math.Max(1, (int)Math.Ceiling(totalCategories / (double)pageSize));
        page = Math.Clamp(page, 1, totalPages);

        var categories = await categoriesQuery
            .OrderBy(category => category.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.Search = search;

        return View(categories);
    }

    public async Task<IActionResult> Details(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        return category == null ? NotFound() : View(category);
    }

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Category category)
    {
        if (!ModelState.IsValid)
        {
            return View(category);
        }

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        return category == null ? NotFound() : View(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Category category)
    {
        if (id != category.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(category);
        }

        _context.Update(category);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        return category == null ? NotFound() : View(category);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}
