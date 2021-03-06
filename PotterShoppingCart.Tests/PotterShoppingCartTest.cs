﻿using System;
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
            var actual = target.GetTotal(books);

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
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 買一到三集各一本_總金額為300x9折()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 1 },
                new Book() { ID = 3, Price = 100, Quantity = 1 }
            };
            var target = new ShoppingCart();

            // Act
            var expected = 270;
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 買一到四集各一本_總金額為400x8折()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 1 },
                new Book() { ID = 3, Price = 100, Quantity = 1 },
                new Book() { ID = 4, Price = 100, Quantity = 1 }
            };
            var target = new ShoppingCart();

            // Act
            var expected = 320;
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 買一到五集各一本_總金額為500x75折()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 1 },
                new Book() { ID = 3, Price = 100, Quantity = 1 },
                new Book() { ID = 4, Price = 100, Quantity = 1 },
                new Book() { ID = 5, Price = 100, Quantity = 1 }
            };
            var target = new ShoppingCart();

            // Act
            var expected = 375;
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 買EP1一本_EP2一本_EP3兩本_總金額為100x3x9折_add_100()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 1 },
                new Book() { ID = 3, Price = 100, Quantity = 2 },
            };
            var target = new ShoppingCart();

            // Act
            var expected = 370;
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 買EP1一本_EP2兩本_EP3兩本_總金額為100x3x9折_add_100x2x95折()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book() { ID = 1, Price = 100, Quantity = 1 },
                new Book() { ID = 2, Price = 100, Quantity = 2 },
                new Book() { ID = 3, Price = 100, Quantity = 2 },
            };
            var target = new ShoppingCart();

            // Act
            var expected = 460;
            var actual = target.GetTotal(books);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


    }
}
