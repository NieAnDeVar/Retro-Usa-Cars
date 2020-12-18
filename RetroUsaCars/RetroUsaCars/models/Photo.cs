using System;
using static  RetroUsaCars.models.User;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Web.Helpers;
using Npgsql;

namespace RetroUsaCars.models

{
    public class Photo
    {
        public  static  bool AddFile(WebImage photo,int id)
        {
            var newFileName = "";
                var imagePath = "";
                if(photo != null)
                    {
                        var cs =  "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
                        using var con = new NpgsqlConnection(cs);
                        con.Open();

                        using var cmd = new NpgsqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO Users (photoname) VALUES(@newFileName)";
                        newFileName = id.ToString();
                        cmd.Parameters.AddWithValue("newFileName", newFileName);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        imagePath = @"wwwroot\Photos\" + newFileName;

                        photo.Save(@"~\" + imagePath);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                
            
        }

        public static string GetPath(int id)
        {
            var cs = "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  photoname From users WHERE userid =@id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            reader.Read();
            string result = reader.GetString(0);
            reader.Close(); 
            return result;
        }
                    
             
            
            
        


    }
}