using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryManagementApiTest.Models
{
    public partial class Sale
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public int Total { get; set; }
    }
}
