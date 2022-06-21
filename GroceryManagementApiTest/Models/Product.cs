using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryManagementApiTest.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Company { get; set; } = null!;
        public int Price { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
    }
}
