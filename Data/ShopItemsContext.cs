using Capstone4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4.Data
{
    public class ShopItemsContext : DbContext
    {
        public ShopItemsContext(DbContextOptions<ShopItemsContext> options) : base(options)
        {

        }

        public DbSet<Candle> Candles { get; set; }


    }
}

