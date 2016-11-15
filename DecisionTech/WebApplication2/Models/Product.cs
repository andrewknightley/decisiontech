using DecisionTechWeb.Enums;

namespace DecisionTechWeb.Models
{
    public class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }

    }
}
