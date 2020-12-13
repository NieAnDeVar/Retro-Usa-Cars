using System.Text.RegularExpressions;
using Dapper;
using System.Collections.Generic;
using System.Data;    
using System.Linq;
using Microsoft.Data.SqlClient;


namespace RetroUsaCars.models
{
    public class User
    {
        public int balance;
        public bool IsAdmin;
        public bool IsAvailable;
        public string password;
        public int userid;
        public string usermail;
        public string username;
        public static bool Register( string email, string pas1, string pas2, string username)
        {
            if (ValidateEmail(email) || ValidatePass(pas1, pas2)|| ValidateEmailRepeat(email))
            {
                Create(email, pas1, username);
                return true;
            }
            else
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
            string connectionString = "Host=localhost; " +
                                      "Username=postgres;" +
                                      "Password = qwerty;" +
                                      "Database = Retro Usa Cars;";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                
                var sqlQuery = "INSERT INTO Users (balance, isadmin,isavailable, password,usermail,name) VALUES(0,false,true,@email,@pas1, @username)";
                db.Execute(sqlQuery, (email,  pas1));
                
            }
        }

        public static bool ValidateEmailRepeat(string email)
        {
            string connectionString = "Host=localhost; " +
                                      "Username=postgres;" +
                                      "Password = qwerty;" +
                                      "Database = Retro Usa Cars;";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                
                var sqlQuery = "SELECT name From Users WHERE usermail = @email ";
                if (db.Execute(sqlQuery,email) == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
    

}