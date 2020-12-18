using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using RetroUsaCars.models;
using static RetroUsaCars.models.User;

namespace RetroUsaCars.Pages
{
    public class AdminAccount : PageModel
    {
        public IActionResult OnGet()
        {
            User user = new User();
            user = CheckLoginAndLogin(HttpContext.Request.Cookies["Email"], HttpContext.Request.Cookies["Pass"]);
            if (user.IsAdmin)
            {
                return null;
            }
            else
                return Redirect("/Log in");

        }
        [BindProperty] public string email { get; set; } 
        
        public void OnPost()
        {
            var cs =  "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE users SET isavailable = false WHERE usermail =@email";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}