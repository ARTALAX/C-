namespace WpfApp
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"{Name} - {Price:C}";
    }
}
