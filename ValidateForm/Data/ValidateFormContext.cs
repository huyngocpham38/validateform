using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ValidateForm.Models
{
    public class ValidateFormContext : DbContext
    {
        public ValidateFormContext (DbContextOptions<ValidateFormContext> options)
            : base(options)
        {
        }

        public DbSet<ValidateForm.Models.Product> Product { get; set; }
    }
}
