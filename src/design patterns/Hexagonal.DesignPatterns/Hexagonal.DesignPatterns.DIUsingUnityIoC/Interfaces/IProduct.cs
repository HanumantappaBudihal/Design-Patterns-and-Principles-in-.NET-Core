namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        decimal Price { get; set; }
    }
}
