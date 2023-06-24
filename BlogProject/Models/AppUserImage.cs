﻿using Microsoft.AspNetCore.Http;

namespace BlogProject.Models
{
    public class AppUserImage
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public IFormFile Image { get; set; }
    }
}