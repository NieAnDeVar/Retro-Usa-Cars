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
        [BindProperty]
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
        
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            Register(usermail, password,password2, usermail);
        }
    }
}