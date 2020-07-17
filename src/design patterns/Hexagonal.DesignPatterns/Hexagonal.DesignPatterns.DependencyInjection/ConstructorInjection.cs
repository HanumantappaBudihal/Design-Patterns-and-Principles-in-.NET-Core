using System;

namespace Hexagonal.DesignPatterns.DependencyInjection
{
    // All interface and class should be create as different files
    // but for better undestading I kept all stuffs in a single file
    /// <summary>
    /// This is a widely used way to implement DI.
    ///Dependency Injection is done by supplying the DEPENDENCY through the class’s constructor when creating the instance of that class.
    ///Injected component can be used anywhere within the class.
    ///Recommended to use when the injected dependency, you are using across the class methods.
    ///It addresses the most common scenario where a class requires one or more dependencies.
    /// </summary>
    /// 

    public interface IService
    {
        void Serve();
    }

    public class Service1 : IService
    {
        public void Serve() { Console.WriteLine("Service1] one Called"); }
    }

    public class Service2 : IService
    {
        public void Serve() { Console.WriteLine("Service two Called"); }
    }

    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            this._service = service;
        }
        public void ServeMethod() 
        { 
            this._service.Serve(); 
        }
    }


    public class ConstructorInjection
    {
        static void Main(string[] args)
        {
            //creating object
            Service1 service1 = new Service1();
            //passing dependency
            Client client = new Client(service1);
            //TO DO:

            Service2 service2 = new Service2();
            //passing dependency
            client = new Client(service2);
        }
    }
}
