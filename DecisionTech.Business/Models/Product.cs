using DecisionTech.Business.Enums;

namespace DecisionTech.Business.Models
{
    public class Product
    {
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }

        public virtual void CheckDiscount()
        {

        }
    }
}
