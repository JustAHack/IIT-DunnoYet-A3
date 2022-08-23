using FoolProof.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TiMePrototype.Domain;

namespace TiMePrototype.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public Shift? Shift { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        // Redirect to page detailing daily earnings

        return Page();
    }
}

