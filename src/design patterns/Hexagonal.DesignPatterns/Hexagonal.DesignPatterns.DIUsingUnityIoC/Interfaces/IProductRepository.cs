using System.Collections.Generic;

namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<IProduct> GetAll();
        IProduct Get(int id);
        IProduct Add(IProduct item);
        bool Update(IProduct item);
        bool Delete(int id);
    }
}
