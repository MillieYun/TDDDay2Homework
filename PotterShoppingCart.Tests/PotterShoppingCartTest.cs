using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// PotterShoppingCartTest 的摘要描述
    /// </summary>
    [TestClass]
    public class PotterShoppingCartTest
    {
        
        [TestMethod]
        public void 買一本第一集_總金額為100()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 }
            };
            var target = new ShoppingCart();

            // Act
            var expected = 100;
            var actual = target.GetSum(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 100 * 2 * 0.95 = 190
        /// </summary>
        [TestMethod]
        public void 買一本第一集一本第二集_總金額為200x95折()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 1 }
            };
            var target = new ShoppingCart();

            // Act
            var expected = 190;
            var actual = target.GetSum(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


    }
}
