using System.Collections.Generic;
using System.Drawing;
using System.Web.Helpers;
using Npgsql;

namespace RetroUsaCars.models
{
    public class Car
    {
        public int id { get; set; }
        public string brand{ get; set; }
        public string models{ get; set; }
        public string photoname{ get; set; }
        public int price{ get; set; }
        public bool isavailable{ get; set; }
        public string color{ get; set; }
        
        private List<Car> ShowCarWithModelOrBrand(string s)
        {
            List<Car> list = new List<Car>();
            var cs = "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * From Cars WHERE ((brand =@brand ) or( model = @model)) ";
            cmd.Parameters.AddWithValue("brand", s);
            cmd.Parameters.AddWithValue("model", s);
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            { 
                if (reader.HasRows)
                { 
                  list.Add(new Car()
                  {
                      brand = reader.GetString(0),
                      models = reader.GetString(1),
                      color = reader.GetString(2),
                      photoname = reader.GetString(3),
                      price = reader.GetInt32(4),
                      isavailable = reader.GetBoolean(5),
                      id = reader.GetInt32(6)
                  });
                }
            }

            reader.Close();
            return list;
        }
        private List<Car> ShowCarWithColor(string s)
        {
            List<Car> list = new List<Car>();
            var cs = "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * From Cars WHERE (color =@color) ";
            cmd.Parameters.AddWithValue("color", s);
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            { 
                if (reader.HasRows)
                { 
                    list.Add(new Car()
                    {
                        brand = reader.GetString(0),
                        models = reader.GetString(1),
                        color = reader.GetString(2),
                        photoname = reader.GetString(3),
                        price = reader.GetInt32(4),
                        isavailable = reader.GetBoolean(5),
                        id = reader.GetInt32(6)
                    });
                }
            }

            reader.Close();
            return list;
        }
        private List<Car> ShowCarWithModelOrBrandAndColor(string s,string color)
        {
            List<Car> list = new List<Car>();
            var cs = "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
            using var con = new NpgsqlConnection(cs);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT  * From Cars WHERE ((brand =@brand ) or( model = @model) and(color =@color)) ";
            cmd.Parameters.AddWithValue("brand", s);
            cmd.Parameters.AddWithValue("model", s);
            cmd.Parameters.AddWithValue("color", color);
            cmd.Prepare();
            var reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            { 
                if (reader.HasRows)
                { 
                    list.Add(new Car()
                    {
                        brand = reader.GetString(0),
                        models = reader.GetString(1),
                        color = reader.GetString(2),
                        photoname = reader.GetString(3),
                        price = reader.GetInt32(4),
                        isavailable = reader.GetBoolean(5),
                        id = reader.GetInt32(6)
                    });
                }
            }

            reader.Close();
            return list;
        }

        public List<Car> ShowCar(string BrandOrModel, string color)
        {
            List<Car> list = new List<Car>();
            if (color != null)
            {
                if (BrandOrModel!= null)
                {
                    list = ShowCarWithModelOrBrand(BrandOrModel);
                }else
                {
                    list = null;
                }
            }
            else
            {
                if (BrandOrModel!=null)
                {
                    list = ShowCarWithModelOrBrandAndColor(BrandOrModel, color);

                }
                else
                {
                    list = ShowCarWithColor(color);
                }
                
            }

            return list;
        }

        public static bool AddCarPhoto(int id, WebImage photo)
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
                cmd.CommandText = "UPDATE Cars SET photoname = @newFileName WHERE id = @id";
                newFileName = id.ToString();
                cmd.Parameters.AddWithValue("newFileName", newFileName);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                imagePath = @"wwwroot\PhotosCars\" + newFileName;

                photo.Save(@"~\" + imagePath);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AddCar(string brand,string model, string color, int price, WebImage webImage)
        {
            if (brand != null && model != null && color != null && price != null && webImage != null)
            {


                var cs = "Host=localhost;Username=postgres;Password=qwerty;Database=Retro Usa Cars;";
                using var con = new NpgsqlConnection(cs);
                con.Open();

                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "INSERT INTO Car (brand,model,color,photoname,price,isavailable) VALUES(@brand,@model,@color, 'default.png',@price,true)";
                cmd.Parameters.AddWithValue("brand", brand);
                cmd.Parameters.AddWithValue("model", model);
                cmd.Parameters.AddWithValue("color", color);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cmd.CommandText =
                    "SELECT id FROM Cars WHERE (brand = @brand,model = @model,color = @color,price = @price)";
                var reader = cmd.ExecuteReader();
                reader.Read();
                AddCarPhoto(reader.GetInt32(0), webImage);
                con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}