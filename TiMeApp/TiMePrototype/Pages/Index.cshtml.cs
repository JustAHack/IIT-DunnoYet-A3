using FoolProof.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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

public class Shift
{
    [Required]
    [Display(Name = "Start time")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
    [LessThan("EndTime", ErrorMessage = "Start time must be earlier than end time")]
    public DateTime StartTime { get; set; }

    [Required]
    [Display(Name = "End time")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
    [GreaterThan("StartTime", ErrorMessage = "End time must not be earlier than start time")]
    public DateTime EndTime { get; set; }

    [Required]
    [Display(Name = "Hourly Rate")]
    public decimal HourlyRate { get; set; } = 0;
}