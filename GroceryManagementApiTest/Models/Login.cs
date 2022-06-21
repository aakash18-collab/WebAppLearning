using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryManagementApiTest.Models
{
    public partial class Login
    {
        [Key]
        public int LoginId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
