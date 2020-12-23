using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetroUsaCars.models;
using static RetroUsaCars.models.User;

namespace RetroUsaCars.Pages
{
    public class SearchCar : PageModel
    {
        
        public IActionResult OnGet()
        {
           /* User user = new User();
            user = CheckLoginAndLogin(HttpContext.Request.Cookies["Email"], HttpContext.Request.Cookies["Pass"]);
            if (user.password == null)
            {
                return Redirect("/Log in");
            }
            else
            {*/
                return null;
            //}
        }

        public void OnPost()
        {
            
        }
    }
}