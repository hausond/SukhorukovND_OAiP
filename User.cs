﻿
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;


namespace WebApplication7
{

    [Table("user")]
    public class User : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("login")]
        public string Login { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("city_id")]
        public int? city_id { get; set; }
    }
}
