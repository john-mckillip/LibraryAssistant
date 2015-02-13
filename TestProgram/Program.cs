using LibraryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Terry", "Jackson", "630-744-6969", "terry@space.com");
            Customer customer2 = new Customer("Jason", "Voorhees", "630-744-6969", "jason@killYou.com");

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);

            CustomerObjectToSerialize objectToSerialize = new CustomerObjectToSerialize();
            objectToSerialize.Customers = customers;

            CustomerSerializer serializer = new CustomerSerializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);
        }
    }
}
