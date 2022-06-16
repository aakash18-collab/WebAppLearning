using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppLearning.Models;

namespace WebAppLearning.Data
{
    public class WebAppLearningContext : DbContext
    {
        public WebAppLearningContext (DbContextOptions<WebAppLearningContext> options)
            : base(options)
        {
        }
       
        public DbSet<WebAppLearning.Models.Student> Student { get; set; }
    }
}
