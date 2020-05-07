using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BlazejKustraHellow
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                City = "Krakow",
                CompanyName = "Blazej",
                Street = "Mydlniki",
                Discount = 5,
            };
            Supplier supplier = new Supplier
            {
                City = "Krakow",
                CompanyName = "Drewit",
                Street = "Pradnicka 21",
                BankAccountNumber = 123456789
            };

            ProductContext productContext = new ProductContext();

            productContext.Companies.Add(customer);
            productContext.Companies.Add(supplier);

            productContext.SaveChanges();

            var query = productContext.Companies
                .OfType<Customer>().ToList();

            foreach(var item in query)
            {
                Console.WriteLine(item.Discount);
            }
        }
    }
}