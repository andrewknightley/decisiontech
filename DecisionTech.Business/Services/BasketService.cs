using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DecisionTech.Business.Enums;
using DecisionTech.Business.Models;

namespace DecisionTech.Business
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class BasketService
    {
        public ProductBasket productBasket { get; set; }
        public BasketService()
        {
            var butter = new Product(){Name = "Butter", Type = ProductType.Butter, Price = 0.80};
            var milk = new Product(){Name = "Milk", Type = ProductType.Milk, Price = 1.15};
            var bread = new Product(){Name = "Bread", Type = ProductType.Bread, Price = 1.00};

            productBasket = ProductBasket.Build();

            AddProduct(butter);
            AddProduct(milk);
            AddProduct(bread);
            
        }

        public ProductBasket Get()
        {
            return productBasket;
        }

        public List<Product> AddProduct(Product product)
        {
            productBasket.Basket.Add(product);
            return productBasket.Basket;
        }
    }

    
}
