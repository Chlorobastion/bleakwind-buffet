/*
 * Author: Sebastian Neal
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using System.Linq;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Tests for the Menu class.
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// Tests if all entrees are included on list.
        /// </summary>
        [Fact]
        public void ShouldIncludeAllEntrees()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            Assert.Collection(entrees,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString())
                );
        }

        /// <summary>
        /// Tests if all sides are included on list.
        /// </summary>
        [Fact]
        public void ShouldIncludeAllSides()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();
            Assert.Collection(sides,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString())
                );
        }

        /// <summary>
        /// Tests if all drinks are included on list.
        /// </summary>
        [Fact]
        public void ShouldIncludeAllDrinks()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            Assert.Collection(drinks,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
        }

        /// <summary>
        /// Tests if all menu items are included on list.
        /// </summary>
        [Fact]
        public void ShouldIncludeAllMenuItems()
        {
            IEnumerable<IOrderItem> menu = Menu.FullMenu();
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()),
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
        }

        /// <summary>
        /// Tests if the search method works with an empty string.
        /// </summary>
        [Fact]
        public void SearchShouldFunctionBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.Search(fullMenu, "");
            Assert.Equal(fullMenu, foundItems);
        }

        /// <summary>
        /// Tests if the search method works with various strings.
        /// </summary>
        /// <param name="searchTerms">Terms to filter from full menu list.</param>
        [Theory]
        [InlineData("Aretino")]
        [InlineData("aretino")]
        [InlineData("th")]
        public void SearchShouldFunction(string searchTerms)
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.Search(fullMenu, searchTerms);
            searchTerms = searchTerms.ToUpper();
            if (searchTerms.Equals("ARETINO"))
            {
                List<IOrderItem> expectedItems = new List<IOrderItem>();
                expectedItems.Add(new AretinoAppleJuice());
                AretinoAppleJuice ajM = new AretinoAppleJuice();
                ajM.Size = Data.Enums.Size.Medium;
                expectedItems.Add(ajM);
                AretinoAppleJuice ajL = new AretinoAppleJuice();
                ajL.Size = Data.Enums.Size.Large;
                expectedItems.Add(ajL);
                int index = 0;
                Assert.Equal(expectedItems.Count, foundItems.Count()); // Make sure lists are same size
                foreach (IOrderItem item in expectedItems)
                {
                    Assert.Equal(item.Name, foundItems.ElementAt(index).Name); // Make sure list elements match
                    index++;
                }
            }
            else if (searchTerms.Equals("TH"))
            {
                List<IOrderItem> expectedItems = new List<IOrderItem>();
                expectedItems.Add(new ThalmorTriple());
                expectedItems.Add(new ThugsTBone());
                expectedItems.Add(new CandlehearthCoffee());
                CandlehearthCoffee ccM = new CandlehearthCoffee();
                ccM.Size = Data.Enums.Size.Medium;
                expectedItems.Add(ccM);
                CandlehearthCoffee ccL = new CandlehearthCoffee();
                ccL.Size = Data.Enums.Size.Large;
                expectedItems.Add(ccL);
                expectedItems.Add(new MarkarthMilk());
                MarkarthMilk mmM = new MarkarthMilk();
                mmM.Size = Data.Enums.Size.Medium;
                expectedItems.Add(mmM);
                MarkarthMilk mmL = new MarkarthMilk();
                mmL.Size = Data.Enums.Size.Large;
                expectedItems.Add(mmL);
                int index = 0;
                Assert.Equal(expectedItems.Count, foundItems.Count()); // Make sure lists are same size
                foreach (IOrderItem item in expectedItems)
                {
                    Assert.Equal(item.Name, foundItems.ElementAt(index).Name); // Make sure list elements match
                    index++;
                }
            }
        }

        /// <summary>
        /// Tests if the filter by category method works without any categories.
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldFunctionBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCategory(fullMenu, new List<string>());
            Assert.Equal(fullMenu, foundItems);
        }

        /// <summary>
        /// Tests if the filter by category method works with entrees.
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldFunctionEntree()
        {
            List<string> filter = new List<string>();
            filter.Add("Entree");
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> entrees = Menu.Entrees();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCategory(fullMenu, filter);
            int index = 0;
            Assert.Equal(entrees.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem entree in entrees)
            {
                Assert.Equal(entree.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by category method works with drinks
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldFunctionDrink()
        {
            List<string> filter = new List<string>();
            filter.Add("Drink");
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCategory(fullMenu, filter);
            int index = 0;
            Assert.Equal(drinks.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem drink in drinks)
            {
                Assert.Equal(drink.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by category method works with sides
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldFunctionSide()
        {
            List<string> filter = new List<string>();
            filter.Add("Side");
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> sides = Menu.Sides();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCategory(fullMenu, filter);
            int index = 0;
            Assert.Equal(sides.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem side in sides)
            {
                Assert.Equal(side.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by category method works with all categories simultaneously
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldFunctionAll()
        {
            List<string> filter = new List<string>();
            filter.Add("Entree");
            filter.Add("Side");
            filter.Add("Drink");
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCategory(fullMenu, filter);
            int index = 0;
            Assert.Equal(fullMenu.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in fullMenu)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by calories method works with min and max both null
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldFunctionMinAndMaxBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCalories(fullMenu, null, null);
            Assert.Equal(fullMenu, foundItems);
        }

        /// <summary>
        /// Tests if the filter by calories method works with min null and max a number
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldFunctionMinBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCalories(fullMenu, null, 7);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new CandlehearthCoffee());
            expectedItems.Add(new WarriorWater());
            WarriorWater wwM = new WarriorWater();
            wwM.Size = Data.Enums.Size.Medium;
            expectedItems.Add(wwM);
            WarriorWater wwL = new WarriorWater();
            wwL.Size = Data.Enums.Size.Large;
            expectedItems.Add(wwL);
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by calories method works with max null and min a number
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldFunctionMaxBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCalories(fullMenu, 943, null);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new ThalmorTriple());
            expectedItems.Add(new ThugsTBone());
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by calories method works with min and max a number
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldFunction()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByCalories(fullMenu, 843, 943);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new DoubleDraugr());
            expectedItems.Add(new ThalmorTriple());
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by price method works with min and max null
        /// </summary>
        [Fact]
        public void FilterByPriceShouldFunctionMinAndMaxBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByPrice(fullMenu, null, null);
            Assert.Equal(fullMenu, foundItems);
        }

        /// <summary>
        /// Tests if the filter by price method works with min null and max a number
        /// </summary>
        [Fact]
        public void FilterByPriceShouldFunctionMinBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByPrice(fullMenu, null, 0.42);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new DragonbornWaffleFries());
            expectedItems.Add(new WarriorWater());
            WarriorWater wwM = new WarriorWater();
            wwM.Size = Data.Enums.Size.Medium;
            expectedItems.Add(wwM);
            WarriorWater wwL = new WarriorWater();
            wwL.Size = Data.Enums.Size.Large;
            expectedItems.Add(wwL);
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by price method works with max null and min a number
        /// </summary>
        [Fact]
        public void FilterByPriceShouldFunctionMaxBlank()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByPrice(fullMenu, 7.23, null);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new DoubleDraugr());
            expectedItems.Add(new PhillyPoacher());
            expectedItems.Add(new ThalmorTriple());
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }

        /// <summary>
        /// Tests if the filter by calories method works with min and max a number
        /// </summary>
        [Fact]
        public void FilterByPriceShouldFunction()
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            IEnumerable<IOrderItem> foundItems = Menu.FilterByPrice(fullMenu, 7.23, 7.32);
            List<IOrderItem> expectedItems = new List<IOrderItem>();
            expectedItems.Add(new DoubleDraugr());
            expectedItems.Add(new PhillyPoacher());
            int index = 0;
            Assert.Equal(expectedItems.Count(), foundItems.Count()); // Make sure lists are same size
            foreach (IOrderItem item in expectedItems)
            {
                Assert.Equal(item.Name, foundItems.ElementAt(index).Name);
                index++;
            }
        }
    }
}
