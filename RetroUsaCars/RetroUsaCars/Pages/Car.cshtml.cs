using System;
using System.Collections.Generic;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetroUsaCars.models;
using static RetroUsaCars.models.User; 
using static RetroUsaCars.models.Car; 
namespace RetroUsaCars.Pages
{
    public class Car : PageModel
    {    
        [BindProperty]
        public User user { get; set; }

        [BindProperty]
        public string color { get; set; }
        [BindProperty]
        public string BrandOrNameCar { get; set; }

        public List<RetroUsaCars.models.Car> list;

        
        public IActionResult OnGet()
        {
            
            if ((HttpContext.Request.Cookies.ContainsKey("Pass")))
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
                    color = HttpContext.Request.Cookies["Color"];
                    BrandOrNameCar = HttpContext.Request.Cookies["Brand"];
                    list = RetroUsaCars.models.Car.ShowCar(BrandOrNameCar, color);
                    HttpContext.Response.Cookies.Delete("Color");
                    HttpContext.Response.Cookies.Delete("Brand");
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