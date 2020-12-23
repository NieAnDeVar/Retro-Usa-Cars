using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using RetroUsaCars.models;
using static RetroUsaCars.models.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;


namespace RetroUsaCars.Pages
{
    public class Log_in : PageModel
    { 
        
        User userReg{ get; set;}
        [BindProperty]
        public string password { get; set; }

        [BindProperty]
        public string password2 { get; set; }
        [BindProperty]
        public int userid { get; set; }
        [BindProperty]
        public string usermail { get; set; }
        [BindProperty]
        public string username { get; set; }
        
        [BindProperty]
        public string LEmail { get; set; }
        [BindProperty]
        public string LPass { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPostLog()
        {


            User Log = CheckLoginAndLogin(LEmail, LPass);
            
            if (Log.password != null)
            {

                HttpContext.Response.Cookies.Append("Email", LEmail);
                HttpContext.Response.Cookies.Append("Pass",LPass);
                HttpContext.Response.Cookies.Append("Id", Log.userid.ToString());
                return Redirect("/Account");
            }
            return Redirect("/Fail");
            
        }

        public IActionResult OnPostReg()
        {
            if (Register(usermail, password, password2, username))
            
            {
                return Redirect("/Success");
            }
            else
            {
                return Redirect("/Fail");
            }
        }
    }
}