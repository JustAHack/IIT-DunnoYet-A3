using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Claims;
using System.Xml.Linq;

namespace TiMePrototype.Pages.Account;

[AutoValidateAntiforgeryToken]
public class LoginModel : PageModel
{
    [BindProperty]
    public Credential? Credential { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();

        // Verify credentials (not real world verification)
        if (Credential!.UserName == "admin" && Credential.Password == "password")
        {
            // Create security context
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "admin"),
            new Claim(ClaimTypes.Email, "admin@mywebsite.com"),
        };

            ClaimsIdentity identity = new ClaimsIdentity(claims, "MyCookieAuth");
            ClaimsPrincipal claimsPrincipal = new(identity);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = Credential.RememberMe,
            };

            await HttpContext.SignInAsync("CookieAuth", claimsPrincipal, authProperties);

            return RedirectToPage("/Index");
        }
        return Page();
    }
}

public class Credential
{
[Required]
[Display(Name = "User name")]
public string? UserName { get; set; }

[Required]
[DataType(DataType.Password)]
public string? Password { get; set; }

[Display(Name = "Remember Me")]
public bool RememberMe { get; set; } = false;
}