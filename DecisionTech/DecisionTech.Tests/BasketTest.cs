using System;
using DecisionTechWeb.Enums;
using DecisionTechWeb.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecisionTechWeb.Services;

namespace DecisionTech.Tests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var basketService = new BasketService();

            // Could've added these a lists but didnt feel it necessary for the scale of these tests
            var butter = new Product() { Name = "Butter", Type = ProductType.Butter, Price = 0.80 };
            var milk = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var bread = new Product() { Name = "Bread", Type = ProductType.Bread, Price = 1.00 };
            var expected = 2.95;

            basketService.AddProduct(butter);
            basketService.AddProduct(milk);
            basketService.AddProduct(bread);

            double actual = basketService.GetTotal();
            Assert.AreEqual(expected, actual, 0.001, "TestMethod1 Failed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            var basketService = new BasketService();

            // Could've added these a lists but didnt feel it necessary for the scale of these tests
            var butter1 = new Product() { Name = "Butter", Type = ProductType.Butter, Price = 0.80 };
            var butter2 = new Product() { Name = "Butter", Type = ProductType.Butter, Price = 0.80 };
            var bread1 = new Product() { Name = "Bread", Type = ProductType.Bread, Price = 1.00 };
            var bread2 = new Product() { Name = "Bread", Type = ProductType.Bread, Price = 1.00 };
            var expected = 3.10;

            basketService.AddProduct(butter1);
            basketService.AddProduct(butter2);
            basketService.AddProduct(bread1);
            basketService.AddProduct(bread2);

            double actual = basketService.GetTotal();
            Assert.AreEqual(expected, actual, 0.001, "TestMethod2 Failed");
        }

        [TestMethod]
        public void TestMethod3()
        {
            var basketService = new BasketService();

            // Could've added these a lists but didnt feel it necessary for the scale of these tests
            var milk1 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk2 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk3 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk4 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var expected = 3.45;

            basketService.AddProduct(milk1);
            basketService.AddProduct(milk2);
            basketService.AddProduct(milk3);
            basketService.AddProduct(milk4);

            double actual = basketService.GetTotal();
            Assert.AreEqual(expected, actual, 0.001, "TestMethod3 Failed");
        }

        [TestMethod]
        public void TestMethod4()
        {
            var basketService = new BasketService();

            // Could've added these a lists but didnt feel it necessary for the scale of these tests
            var milk1 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk2 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk3 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk4 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk5 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk6 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk7 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var milk8 = new Product() { Name = "Milk", Type = ProductType.Milk, Price = 1.15 };
            var butter1 = new Product() { Name = "Butter", Type = ProductType.Butter, Price = 0.80 };
            var butter2 = new Product() { Name = "Butter", Type = ProductType.Butter, Price = 0.80 };
            var bread1 = new Product() { Name = "Bread", Type = ProductType.Bread, Price = 1.00 };

            basketService.AddProduct(milk1);
            var expected = 9.00;

            basketService.AddProduct(butter1);
            basketService.AddProduct(butter2);
            basketService.AddProduct(bread1);
            basketService.AddProduct(milk2);
            basketService.AddProduct(milk3);
            basketService.AddProduct(milk4);
            basketService.AddProduct(milk5);
            basketService.AddProduct(milk6);
            basketService.AddProduct(milk7);
            basketService.AddProduct(milk8);


            double actual = basketService.GetTotal();
            Assert.AreEqual(expected, actual, 0.001, "TestMethod4 Failed");
        }
    }
}
