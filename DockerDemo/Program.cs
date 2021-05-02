using System;

namespace DockerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mongoWrapper = new MongoWrapper("mongodb://admin:password@192.168.29.101:27017");
            mongoWrapper.InsertData("my-db", "users", new Users { Interests = "Football", Email = "abc@abc.com", Name = "test", Userid = 2 });
            var result = mongoWrapper.GetData("my-db", "users");

            foreach (var customer in result)
            {
                Console.WriteLine($"the name of the customer is {customer.Name} and the ID is {customer.Id}");
            }
            Console.ReadLine();
        }
    }
}
