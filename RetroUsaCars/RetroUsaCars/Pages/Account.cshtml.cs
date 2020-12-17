using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetroUsaCars.models;
using static RetroUsaCars.models.User; 
namespace RetroUsaCars.Pages
{
    public class Account : PageModel
    {    
        [BindProperty]
        public User user { get; set; }
        public IActionResult OnGet()
        {
            
            if ((HttpContext.Request.Cookies.ContainsKey("Email"))&& (HttpContext.Request.Cookies.ContainsKey("Pass")))
            {
                string Email = HttpContext.Request.Cookies["Email"];   
                string Pass = HttpContext.Request.Cookies["Pass"];
                
                user = CheckLoginAndLogin(Email, Pass);
                if (user.password == null)
                {
                    return Redirect("/Log in");
                }
                else
                {
                    

                    return null;
                }
            }
            else
            {
                return Redirect("/Log in");
            }


        }
    }
}