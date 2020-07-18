using Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces;

namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.Models
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}