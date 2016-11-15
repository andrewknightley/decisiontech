using System.Collections.Generic;
using System.Linq;

namespace DecisionTech.Business.Models
{
    public class ProductBasket
    {
        public List<Product> Basket { get; set; }

        private ProductBasket()
        {
        }

        public static ProductBasket Build(IEnumerable<Product> basketModel)
        {
            return new ProductBasket()
            {
                Basket = basketModel.ToList()
            };
        }

        public static ProductBasket Build()
        {
            return new ProductBasket()
            {
                Basket = new List<Product>()
            };
        }
    }
}
