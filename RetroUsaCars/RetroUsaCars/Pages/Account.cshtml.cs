using System;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetroUsaCars.models;
using static RetroUsaCars.models.User; 
using static RetroUsaCars.models.Photo; 
namespace RetroUsaCars.Pages
{
    public class Account : PageModel
    {    
        [BindProperty]
        public User user { get; set; }

        [BindProperty]
        public WebImage photo { get; set; }

        public IActionResult OnGet()
        {
            
            if ((HttpContext.Request.Cookies.ContainsKey("Email"))&& (HttpContext.Request.Cookies.ContainsKey("Pass")))
            {
                string Email = HttpContext.Request.Cookies["Email"];   
                string Pass = HttpContext.Request.Cookies["Pass"];
                
                user = CheckLoginAndLogin(Email, Pass);
                if (user.password == null)
                {
                    return Redirect("/Fail"); 
                }
                else
                {
                    if (user.IsAdmin)
                    {
                        return Redirect("/AdminAccount");
                    }
                    else
                    {
                        return null;
                        
                    }
                    

                    
                }
            }
            else
            {
                return Redirect("/Log in");
            }


        }

        public IActionResult OnPost()
        {
            
            
            
            
            
            if (AddFile(photo,Convert.ToInt32(HttpContext.Request.Cookies["id"])))
            {
                return Redirect("/Account");
            }
            else
            {
                return Redirect("/Fail");
            }


        }


        
    }
}