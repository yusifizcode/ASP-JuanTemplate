using JuanTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanTemplate.DAL
{
    public class JuanDbContext:DbContext
    {
        public JuanDbContext(DbContextOptions<JuanDbContext> options) : base(options)
        {
                
        }

        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<HomeFeatures> HomeFeatures { get; set; }
    }
}
