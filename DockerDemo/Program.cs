using System;

namespace DockerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mongoWrapper = new MongoWrapper("mongodb://admin:password@localhost:27017");
            var result = mongoWrapper.GetData("my-db", "users");

            foreach (var customer in result)
            {
                Console.WriteLine($"the name of the customer is {customer.Name} and the ID is {customer.Id}");
            }
            Console.ReadLine();
        }
    }
}
