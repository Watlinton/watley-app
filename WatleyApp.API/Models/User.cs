using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatleyApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
