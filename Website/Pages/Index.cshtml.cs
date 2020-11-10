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
using System.ComponentModel;

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
            
            // Old searching and filtering methods
            //Items = Menu.Search(Items, SearchTerms);
            //List<string> categories = new List<string>();
            //foreach (string category in Categories)
            //{
            //    categories.Add(category);
            //}
            //Items = Menu.FilterByCategory(Items, categories);
            //Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            //Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);

            // New searching and filtering methods using Linq
            Items = Menu.FullMenu();
            // Search for keywords in names and descriptions
            if (SearchTerms != null)
            {
                string[] seperateSearchTerms = SearchTerms.Split(' ');
                List<IOrderItem> foundItems = new List<IOrderItem>();
                foreach (string term in seperateSearchTerms)
                {
                    var nameItemMatch = Items.Where(item => item.Name != null && item.Name.Contains(term, StringComparison.InvariantCultureIgnoreCase));
                    var descriptionItemMatch = Items.Where(item => item.Description != null && item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase));
                    foreach (IOrderItem item in nameItemMatch)
                    {
                        foundItems.Add(item);
                    }
                    foreach (IOrderItem item in descriptionItemMatch)
                    {
                        foundItems.Add(item);
                    }
                }
                Items = foundItems;
            }
            // Filter by specific categories
            if (Categories != null && Categories.Length != 0)
            {
                if (Categories.Length == 3)
                {
                    // All categories are checked, so there is no need to filter by category
                }
                else if (Categories.Length == 2)
                {
                    // Two categories are checked
                    if ((Categories[0].Equals("Entree") || Categories[1].Equals("Entree")) && (Categories[0].Equals("Drink") || Categories[1].Equals("Drink")))
                    {
                        // Entree and drink are selected
                        Items = Items.Where(item => item is Entree || item is Drink);
                    }
                    else if ((Categories[0].Equals("Entree") || Categories[1].Equals("Entree")) && (Categories[0].Equals("Side") || Categories[1].Equals("Side")))
                    {
                        // Entree and side are selected
                        Items = Items.Where(item => item is Entree || item is Side);
                    }
                    else if ((Categories[0].Equals("Side") || Categories[1].Equals("Side")) && (Categories[0].Equals("Drink") || Categories[1].Equals("Drink")))
                    {
                        // Drink and side are selected
                        Items = Items.Where(item => item is Drink || item is Side);
                    }
                }
                else
                {
                    // One category is checked
                    if (Categories[0].Equals("Entree"))
                    {
                        Items = Items.Where(item => item is Entree);
                    }
                    else if (Categories[0].Equals("Side"))
                    {
                        Items = Items.Where(item => item is Side);
                    }
                    else if (Categories[0].Equals("Drink"))
                    {
                        Items = Items.Where(item => item is Drink);
                    }
                }
            }
            // Filter by input prices
            if (PriceMin == null && PriceMax == null)
            { }
            else if (PriceMin == null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
            else if (PriceMax == null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            else
            {
                Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }
            // Filter by input calories
            if (CaloriesMin == null && CaloriesMax == null)
            { }
            else if (CaloriesMin == null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            else if (CaloriesMax == null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            else
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }

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
