using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone4.Data;
using Capstone4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Capstone4.Controllers
{
    public class CandleController : Controller

    {

        private readonly ShopItemsContext _dbContext;
        private ISession _session;

        public CandleController(ShopItemsContext dbContext, IHttpContextAccessor accessor)
        {
            _dbContext = dbContext;
            _session = accessor.HttpContext.Session;
        }
        public IActionResult Index()
        {
            var list = _dbContext.Candles.ToList();
            return View(list);
        }
        public async Task<IActionResult> Add(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _dbContext.Candles
                .FirstOrDefaultAsync(m => m.CandleID == id);

            List<Candle> list;

            if (product == null)
            {
                return NotFound();
            }

            // TODO - Add to session
            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Candle>>(_session.GetString("Cart"));
            }
            else
            {
                list = new List<Candle>();
            }

            list.Add(product);
            _session.SetString("Cart", JsonConvert.SerializeObject(list));

            TempData["Success"] = $"Successfully added {product.Scent} to cart!";
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            List<Candle> list;

            if (_session.Keys.Any(x => x == "Cart"))
            {
                list = JsonConvert.DeserializeObject<List<Candle>>(_session.GetString("Cart"));
                _session.SetString("Cart", JsonConvert.SerializeObject(list));
            }
            else
            {
                list = new List<Candle>();
            }

            for (int i = 0; i < list.Count; i++)
            {
                ViewBag.Total = list.Sum(i => i.CandlePrice);
            }
            return View(list);
        }
    }
}

    

