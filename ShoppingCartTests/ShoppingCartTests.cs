using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ShoppingCart.Tests
{
  [TestClass()]
    public class ShoppingCartTests
    {


        /// <summary>
        /// 第一集買了一本，其他都沒買，價格應為100*1=100元
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_第一集買了一本_其他都沒買_價格應為100()
        {

            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            decimal expected = 100m;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_第一集買了一本_第二集也買了一本_價格應為190()
        {
            //arrange

            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            decimal expected = 190;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 一二三集各買了一本，價格應為100*3*0.9=270
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_一二三集各買了一本_價格應為270()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });

            decimal expected = 270;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 一二三四集各買了一本，價格應為100*4*0.8=320
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_一二三四集各買了一本_價格應為320()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            target.Add(new ProductModel() { ID = 4, Price = 100m });
            decimal expected = 320;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_一次買了整套_一二三四五集各買了一本_價格應為375()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            target.Add(new ProductModel() { ID = 4, Price = 100m });
            target.Add(new ProductModel() { ID = 5, Price = 100m });
            decimal expected = 375;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///  一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            decimal expected = 370;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// 第一集買了一本，第二三集各買了兩本，價格應為100*3*0.9 + 100*2*0.95 = 460
        /// </summary>
        [TestMethod()]
        public void CalAmountTest_第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //arrange
            ShoppingCart target = new ShoppingCart();
            target.Add(new ProductModel() { ID = 1, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 2, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            target.Add(new ProductModel() { ID = 3, Price = 100m });
            decimal expected = 460;

            //act
            decimal actual;
            actual = target.CalAmount();

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}

