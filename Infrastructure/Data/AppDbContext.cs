using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{

        public class AppDbContext : DbContext
        {
        public DbSet<Product> products
        { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }


        }


}

