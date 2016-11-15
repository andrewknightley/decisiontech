using System;
using System.Collections.Generic;
using System.Linq;
using DecisionTechWeb.Enums;
using DecisionTechWeb.Models;

namespace DecisionTechWeb.Services
{
    
    public class BasketService
    {
        private ProductBasket ProductBasket { get; set; }
        private double Total { get; set; }

        public BasketService()
        {
           
            ProductBasket = ProductBasket.Build();
            Total = 0.00;

        }

        public ProductBasket Get()
        {
            return ProductBasket;
        }

        public List<Product> AddProduct(Product product)
        {
            ProductBasket.Basket.Add(product);
            return ProductBasket.Basket;
        }

        public double GetTotal()
        {
            foreach (var p in ProductBasket.Basket)
                Total += p.Price;

            Total -= CalculateBreadOffer();
            Total -= CalculateMilkOffer();

            return Total;
        }

        private double CalculateBreadOffer()
        {
            if (!ProductBasket.Basket.Any()) return 0.00;

            var butterCount = ProductBasket.Basket.Count(x => x.Type == ProductType.Butter);
            var breadCount = ProductBasket.Basket.Count(x => x.Type == ProductType.Bread);

            double discount = 0.00;

            if (butterCount >= 2 && breadCount >= 1)
            {
                var offersEligeable = Math.Floor(butterCount/2.00);
                for (int i = 0; i < offersEligeable; i++)
                {
                    if (breadCount >= offersEligeable)
                    {
                        discount +=
                            ProductBasket.Basket.Where(y => y.Type == ProductType.Bread)
                                .Select(y => y.Price/2)
                                .FirstOrDefault();
                    }
                }
            }

            return discount;
        }

        private double CalculateMilkOffer()
        {
            if (!ProductBasket.Basket.Any()) return 0.00;

            var milkCount = ProductBasket.Basket.Select(x => x.Type == ProductType.Milk).Count();
            double discount = 0.00;

            if (milkCount >= 4)
            {
                double offersEligeable = Math.Floor(milkCount/4.00);
                discount = offersEligeable * ProductBasket.Basket.Where(y => y.Type == ProductType.Milk)
                                .Select(y => y.Price)
                                .FirstOrDefault();
            }

            return discount;
        }
    }

    
}
