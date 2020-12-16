using System;
using System.Text.RegularExpressions;
using Dapper;
using System.Collections.Generic;
using System.Data;    
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Npgsql;
using NpgsqlTypes;


namespace RetroUsaCars.models
{
    public class User
    {
       
        public int balance { get; set; }
     
        public bool IsAdmin { get; set; }
      
        public bool IsAvailable { get; set; }
        
        public string password { get; set; }
        
        public int userid { get; set; }
        
        public string usermail { get; set; }
        
        public string username { get; set; }
        public static bool Register( string email, string pas1, string pas2, string username)
        {
            try
            {
                if (ValidateEmail(email) && ValidatePass(pas1, pas2)&&  !(pas1 == null)&& !(pas2 == null)&& !(username == null))
                {
                    Create(email, pas1, username);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static bool ValidateEmail(string emailAddress)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = (Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase) ||(emailAddress.Length < 21) );
            return isValid;
        }

        public static bool ValidatePass(string pas1, string pas2)
        {
            return ((pas1 == pas2)|| pas1.Length < 21);
        }
        public static void Create(string email, string pas1, string username)
        { 
            var cs =  "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Users (balance, isadmin,isavailable, password,usermail, name) VALUES(0,false,true,@pas1,@email,@username)";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("pas1", pas1);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

        }

        
    }
    

}