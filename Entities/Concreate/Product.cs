namespace Entities.Concreate
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}