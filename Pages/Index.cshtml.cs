using Microsoft.AspNetCore.Mvc.RazorPages;
using Product.Models;

namespace Product.Pages;

public class IndexModel : PageModel
{
    private readonly ProductDbContext _context; //Replaces the db variable
    private readonly ILogger<IndexModel> _logger;
    public List<Products> Products {get; set;} = default!;

    public IndexModel(ProductDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Products = _context.Products.ToList();
    }
}
