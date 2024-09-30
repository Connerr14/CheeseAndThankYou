namespace CheeseAndThankYou.Models
{
    public class Category
    {
        // First property is the primary key
        public int CategoryId { get; set; }

        public string Name { get; set; }

        // How is it releated?
        // child ref to products. Make child nullable so we can first add Categories.
        public List<Product>? Products { get; set; }
    }
}
