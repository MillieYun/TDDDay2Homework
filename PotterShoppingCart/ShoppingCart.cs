using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        /// <summary>
        /// 計算購買金額
        /// </summary>
        /// <param name="books">書藉資料</param>
        /// <returns></returns>
        public int GetSum(List<Book> books)
        {
            
            return books.Sum(b => b.Price);
        }
    }
}