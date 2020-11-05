/*
 * Author: Sebastian Neal
 * Interface name: Menu.cs
 * Purpose: Static class for the Menu.
 */

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Static class used to represent the Menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// This method returns a list of all available entrees at Bleakwind Buffet.
        /// </summary>
        /// <returns>List of all entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();
            entreeList.Add(new BriarheartBurger());
            entreeList.Add(new DoubleDraugr());
            entreeList.Add(new GardenOrcOmelette());
            entreeList.Add(new PhillyPoacher());
            entreeList.Add(new SmokehouseSkeleton());
            entreeList.Add(new ThalmorTriple());
            entreeList.Add(new ThugsTBone());
            return entreeList;
        }

        /// <summary>
        /// This method returns a list of all available sides at Bleakwind Buffet.
        /// </summary>
        /// <returns>List of all sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();
            sideList.Add(new DragonbornWaffleFries());
            DragonbornWaffleFries medDBWF = new DragonbornWaffleFries();
            medDBWF.Size = Size.Medium;
            sideList.Add(medDBWF);
            DragonbornWaffleFries larDBWF = new DragonbornWaffleFries();
            larDBWF.Size = Size.Large;
            sideList.Add(larDBWF);
            sideList.Add(new FriedMiraak());
            FriedMiraak medFM = new FriedMiraak();
            medFM.Size = Size.Medium;
            sideList.Add(medFM);
            FriedMiraak larFM = new FriedMiraak();
            larFM.Size = Size.Large;
            sideList.Add(larFM);
            sideList.Add(new MadOtarGrits());
            MadOtarGrits medMOG = new MadOtarGrits();
            medMOG.Size = Size.Medium;
            sideList.Add(medMOG);
            MadOtarGrits larMOG = new MadOtarGrits();
            larMOG.Size = Size.Large;
            sideList.Add(larMOG);
            sideList.Add(new VokunSalad());
            VokunSalad medVS = new VokunSalad();
            medVS.Size = Size.Medium;
            sideList.Add(medVS);
            VokunSalad larVS = new VokunSalad();
            larVS.Size = Size.Large;
            sideList.Add(larVS);
            return sideList;
        }

        /// <summary>
        /// This method returns a list of all available drinks at Bleakwind Buffet.
        /// </summary>
        /// <returns>List of all drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            drinkList.Add(new AretinoAppleJuice());
            AretinoAppleJuice medAAJ = new AretinoAppleJuice();
            medAAJ.Size = Size.Medium;
            drinkList.Add(medAAJ);
            AretinoAppleJuice larAAJ = new AretinoAppleJuice();
            larAAJ.Size = Size.Large;
            drinkList.Add(larAAJ);
            drinkList.Add(new CandlehearthCoffee());
            CandlehearthCoffee medCC = new CandlehearthCoffee();
            medCC.Size = Size.Medium;
            drinkList.Add(medCC);
            CandlehearthCoffee larCC = new CandlehearthCoffee();
            larCC.Size = Size.Large;
            drinkList.Add(larCC);
            drinkList.Add(new MarkarthMilk());
            MarkarthMilk medMM = new MarkarthMilk();
            medMM.Size = Size.Medium;
            drinkList.Add(medMM);
            MarkarthMilk larMM = new MarkarthMilk();
            larMM.Size = Size.Large;
            drinkList.Add(larMM);
            SailorSoda smaBSS = new SailorSoda();
            smaBSS.Flavor = SodaFlavor.Blackberry;
            drinkList.Add(smaBSS);
            SailorSoda medBSS = new SailorSoda();
            medBSS.Size = Size.Medium;
            medBSS.Flavor = SodaFlavor.Blackberry;
            drinkList.Add(medBSS);
            SailorSoda larBSS = new SailorSoda();
            larBSS.Size = Size.Large;
            larBSS.Flavor = SodaFlavor.Blackberry;
            drinkList.Add(larBSS);
            drinkList.Add(new SailorSoda());
            SailorSoda medSS = new SailorSoda();
            medSS.Size = Size.Medium;
            drinkList.Add(medSS);
            SailorSoda larSS = new SailorSoda();
            larSS.Size = Size.Large;
            drinkList.Add(larSS);
            SailorSoda smaGSS = new SailorSoda();
            smaGSS.Flavor = SodaFlavor.Grapefruit;
            drinkList.Add(smaGSS);
            SailorSoda medGSS = new SailorSoda();
            medGSS.Size = Size.Medium;
            medGSS.Flavor = SodaFlavor.Grapefruit;
            drinkList.Add(medGSS);
            SailorSoda larGSS = new SailorSoda();
            larGSS.Size = Size.Large;
            larGSS.Flavor = SodaFlavor.Grapefruit;
            drinkList.Add(larGSS);
            SailorSoda smaLSS = new SailorSoda();
            smaLSS.Flavor = SodaFlavor.Lemon;
            drinkList.Add(smaLSS);
            SailorSoda medLSS = new SailorSoda();
            medLSS.Size = Size.Medium;
            medLSS.Flavor = SodaFlavor.Lemon;
            drinkList.Add(medLSS);
            SailorSoda larLSS = new SailorSoda();
            larLSS.Size = Size.Large;
            larLSS.Flavor = SodaFlavor.Lemon;
            drinkList.Add(larLSS);
            SailorSoda smaPSS = new SailorSoda();
            smaPSS.Flavor = SodaFlavor.Peach;
            drinkList.Add(smaPSS);
            SailorSoda medPSS = new SailorSoda();
            medPSS.Size = Size.Medium;
            medPSS.Flavor = SodaFlavor.Peach;
            drinkList.Add(medPSS);
            SailorSoda larPSS = new SailorSoda();
            larPSS.Size = Size.Large;
            larPSS.Flavor = SodaFlavor.Peach;
            drinkList.Add(larPSS);
            SailorSoda smaWSS = new SailorSoda();
            smaWSS.Flavor = SodaFlavor.Watermelon;
            drinkList.Add(smaWSS);
            SailorSoda medWSS = new SailorSoda();
            medWSS.Size = Size.Medium;
            medWSS.Flavor = SodaFlavor.Watermelon;
            drinkList.Add(medWSS);
            SailorSoda larWSS = new SailorSoda();
            larWSS.Size = Size.Large;
            larWSS.Flavor = SodaFlavor.Watermelon;
            drinkList.Add(larWSS);
            drinkList.Add(new WarriorWater());
            WarriorWater medWW = new WarriorWater();
            medWW.Size = Size.Medium;
            drinkList.Add(medWW);
            WarriorWater larWW = new WarriorWater();
            larWW.Size = Size.Large;
            drinkList.Add(larWW);
            return drinkList;
        }

        /// <summary>
        /// This method returns a list of all available menu items at Bleakwind Buffet.
        /// </summary>
        /// <returns>List of all menu items.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
             return Entrees().Concat(Sides().Concat(Drinks()));
        }

        /// <summary>
        /// Searches the given list of items to find the items that include the
        /// terms being searched for.
        /// </summary>
        /// <param name="list">The collection of items to search.</param>
        /// <param name="terms">The terms to search for in the items.</param>
        /// <returns>A list of items that include the terms being searched for.</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> list, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // Null Check
            if (terms == null) return list;
            
            // Split the terms into individual search terms
            string[] allTerms = terms.Split(' ');

            foreach (IOrderItem item in list)
            {
                // Check each seperate search term
                foreach (string term in allTerms)
                {
                    // Add the item if the name has a match
                    if (item.Name != null && item.Name.ToUpper().Contains(terms.ToUpper()))
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the list based on supplied categories.
        /// </summary>
        /// <param name="list">The collection of items to search.</param>
        /// <param name="categories">The categories to filter the items by.</param>
        /// <returns>A list of items that match the filters provided.</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> list, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return list;

            // Filter the supplied collection of items
            List<IOrderItem> results = new List<IOrderItem>();
            
            // Check all supplied categories
            foreach (string category in categories)
            {
                // Check if any items match the current criteria
                foreach (IOrderItem item in list)
                {
                    // Check the category name
                    if(category.Equals("Entree"))
                    {
                        // Check if item is in this category
                        if (item is Entree)
                        {
                            results.Add(item);
                        }
                    }
                    else if (category.Equals("Side"))
                    {
                        if (item is Side)
                        {
                            results.Add(item);
                        }
                    }
                    else if (category.Equals("Drink"))
                    {
                        if (item is Drink)
                        {
                            results.Add(item);
                        }
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the list based on the amount of desired calories.
        /// </summary>
        /// <param name="list">The collection of items to search.</param>
        /// <param name="min">The minimum number of calories desired.</param>
        /// <param name="max">The maximum number of calories desired.</param>
        /// <returns>A list of items that fall within the bounds provided.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> list, int? min, int? max)
        {
            if (min == null && max == null) return list;

            var results = new List<IOrderItem>();

            // only a maximum is specified
            if (min == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum is spcified
            if (max == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // both minimum and maximum specified
            foreach (IOrderItem item in list)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the list based on the desired price.
        /// </summary>
        /// <param name="list">The collection of items to search.</param>
        /// <param name="min">The minimum price desired.</param>
        /// <param name="max">The maximum price desired.</param>
        /// <returns>A list of items that fall within the bounds provided.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            if (min == null && max == null) return list;

            var results = new List<IOrderItem>();

            // only a maximum is specified
            if (min == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum is spcified
            if (max == null)
            {
                foreach (IOrderItem item in list)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // both minimum and maximum specified
            foreach (IOrderItem item in list)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
