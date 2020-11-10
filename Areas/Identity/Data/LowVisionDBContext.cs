using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LowVision.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LowVision.Data
{
    public class LowVisionDBContext : IdentityDbContext<LowVisionUser>
    {
        public LowVisionDBContext(DbContextOptions<LowVisionDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
