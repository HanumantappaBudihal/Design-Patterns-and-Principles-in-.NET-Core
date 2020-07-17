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

    public interface IService3
    {
        void Serve();
    }
    public class Service3 : IService3
    {
        public void Serve() { Console.WriteLine("Service1 Called"); }
    }
    public class Service4 : IService3
    {
        public void Serve() { Console.WriteLine("Service2 Called"); }
    }
    public class Client2
    {
        private IService3 _service;
        public IService3 Service
        {
            set { this._service = value; }
        }
    }

    public class PropertyInjection
    {
        public static void PropertyInjectionMainMethod()
        {
            //creating object
            Service3 service3 = new Service3();

            Client2 client = new Client2();
            client.Service = service3; //passing dependency
                                       //TO DO:

            Service4 service4 = new Service4();
            client.Service = service4; //passing dependency
        }
    }
}
