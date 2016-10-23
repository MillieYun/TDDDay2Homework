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
        public double GetSum(List<Book> books)
        {

            var package = getPackage(books);

            return package.Sum(p => p.Sum(b => b.Price) * getDiscountRate(p.Count()));
        }


        private List<List<Book>> getPackage(List<Book> books)
        {
            var result = new List<List<Book>>();
            int index = 0;

            while (index < books.Max(b => b.Quantity))
            {
                result.Add(books.Where(b => b.Quantity - index > 0).ToList());
                index++;
            }

            return result;

        }

        /// <summary>
        /// 取得組合的折婁 
        /// </summary>
        /// <param name="itemCounts"></param>
        /// <returns></returns>
        private double getDiscountRate(int itemCounts)
        {
            switch(itemCounts)
            {
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
                default:
                    return 1;
            }
        }

    }
}