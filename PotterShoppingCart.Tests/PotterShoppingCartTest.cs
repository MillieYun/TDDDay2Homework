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
                new Book() { Id = 1, Quantity = 1 }
            };
            var target = new PotterShoppingCart();

            // Act
            var expected = 100;
            var actual = target.GetSum(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


    }
}
