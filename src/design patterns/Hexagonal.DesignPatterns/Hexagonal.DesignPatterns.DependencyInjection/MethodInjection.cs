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

    public interface IService5
    {
        void Serve();
    }

    public class Service5 : IService5
    {
        public void Serve() { Console.WriteLine("Service1 Called"); }
    }

    public class Service6 : IService5
    {
        public void Serve() { Console.WriteLine("Service2 Called"); }
    }

    public class Client3
    {
        private IService5 _service;
        public void Start(IService5 service)
        {
            service.Serve();
        }
    }

    public class MethodInjection
    {
        static void Main(string[] args)
        {
            //creating object
            Service5 service5 = new Service5();

            Client3 client3 = new Client3();
            client3.Start(service5); //passing dependency
                              //TO DO:

            Service6 service6 = new Service6();
            client3.Start(service6); //passing dependency
        }
    }
}
