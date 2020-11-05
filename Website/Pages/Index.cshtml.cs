using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Security.Cryptography;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Store all items that should be listed (initially the full menu)
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; } = Menu.FullMenu();

        /// <summary>
        /// Store all entrees that should be listed
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; }

        /// <summary>
        /// Store all sides that should be listed
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get; set; }

        /// <summary>
        /// Store all drinks that should be listed
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; }

        /// <summary>
        /// Terms entered into search bar
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtering categories
        /// </summary>
        public string[] Categories { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum price
        /// </summary>
        public double? PriceMax { get; set; }

        public void OnGet(double? priceMin, double? priceMax, int? caloriesMin, int? caloriesMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            CaloriesMin = caloriesMin;
            CaloriesMax = caloriesMax;
            PriceMin = priceMin;
            PriceMax = priceMax;
            Items = Menu.Search(Items, SearchTerms);
            List<string> categories = new List<string>();
            foreach (string category in Categories)
            {
                categories.Add(category);
            }
            Items = Menu.FilterByCategory(Items, categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            List<IOrderItem> entrees = new List<IOrderItem>();
            List<IOrderItem> sides = new List<IOrderItem>();
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (IOrderItem item in Items)
            {
                if (item is Entree)
                {
                    entrees.Add(item);
                }
                else if (item is Side)
                {
                    sides.Add(item);
                }
                else if (item is Drink)
                {
                    drinks.Add(item);
                }
            }
            Entrees = entrees;
            Sides = sides;
            Drinks = drinks;
        }
    }
}
