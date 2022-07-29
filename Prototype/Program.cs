using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Clone");

            ConcreateProtorype1 Service1 = new ConcreateProtorype1(1500, "test");
            ConcreateProtorype1 Service2 = (ConcreateProtorype1)Service1.Clone();
            Console.WriteLine(Service1.Property1);
            Console.WriteLine(Service2.Property1);
            Console.WriteLine(Service1 == Service2);

            Console.WriteLine("Deep Clone");

            ConcreateProtorype2 serviceComplex1 = new ConcreateProtorype2(Service1);
            var serviceComplex2 = (ConcreateProtorype2)serviceComplex1.Clone();
            Console.WriteLine(serviceComplex1.MyApplicationService.Property2);
            Console.WriteLine(serviceComplex2.MyApplicationService.Property2);
            Console.WriteLine(serviceComplex1 == serviceComplex2);

            Console.ReadKey();
        }
    }
}
