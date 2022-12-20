using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIGiorgia.Models;

namespace WebAPIGiorgia.Data
{
    public class WebAPIGiorgiaContext : DbContext
    {
        public WebAPIGiorgiaContext (DbContextOptions<WebAPIGiorgiaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIGiorgia.Models.ShopList> ShopList { get; set; } = default!;
    }
}
