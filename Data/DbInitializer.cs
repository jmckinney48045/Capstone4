using Capstone4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopItemsContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Candles.Any())
            {
                context.Candles.Add(new Candle() { Scent = "Lavender", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Lavender", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Pine", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Pine", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Citrus", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Citrus", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Cedar", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Cedar", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Apple", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Apple", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Linen", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Linen", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Cotton Candy", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Cotton Candy", CandleType = "Tealight", CandlePrice = 9.50 });
                context.Candles.Add(new Candle() { Scent = "Vanilla", CandleType = "Jar", CandlePrice = 12.50 });
                context.Candles.Add(new Candle() { Scent = "Vanilla", CandleType = "Tealight", CandlePrice = 9.50 });


                context.SaveChanges();

            }

        }
    }
}