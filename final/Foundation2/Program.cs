//Foundation 2

using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Seattle", "WA", "USA");
            Customer customer1 = new Customer("John Doe", address1);

            Address address2 = new Address("456 South East St", "Bangkok", "BK", "Thailand");
            Customer customer2 = new Customer("Jim Dean", address2);

            Product product1 = new Product("Rumba", "R121", 100.0m, 2);
            Product product2 = new Product("Instant Pot", "I459", 50.0m, 1);
            Product product3 = new Product("Air Fryer", "A328", 200.0m, 1);

            Product product4 = new Product("Weight Bench", "WB23", 85.5m, 1);
            Product product5 = new Product("Dumbell", "DB98", 43.2m, 2);
            Product product6 = new Product("Tank Top", "TT28", 19.9m, 2);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            Order order2 = new Order(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);
            order2.AddProduct(product6);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total cost: {order1.GetTotalCost():C}");
            Console.WriteLine();
            
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total cost: {order2.GetTotalCost():C}");
            Console.WriteLine();
        }
    }

    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.products = new List<Product>();
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0.0m;
            foreach (Product product in this.products)
            {
                totalCost += product.Price * product.Quantity;
            }
            if (this.customer.Address.IsInUSA())
            {
                totalCost += 5.0m;
            }
            else
            {
                totalCost += 35.0m;
            }
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in this.products)
            {
                packingLabel += $"{product.Name} ({product.ProductId})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = $"{this.customer.Name}\n{this.customer.Address.ToString()}";
            return shippingLabel;
        }
    }

    class Product
    {
        private string name;
        private string productId;
        private decimal price;
        private int quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name { get { return this.name; } private set { this.name = value; } }
        public string ProductId { get { return this.productId; } private set { this.productId = value; } }
        public decimal Price { get { return this.price; } private set { this.price = value; } }
        public int Quantity { get { return this.quantity; } private set { this.quantity = value; } }
    }

    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name { get { return this.name; } private set { this.name = value; } }
        public Address Address { get { return this.address; } private set { this.address = value; } }
    }

    class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
           StreetAddress = streetAddress;
           City = city;
           StateProvince = stateProvince;
           Country = country;
       }

       public bool IsInUSA()
       {
           return (this.country == "USA");
       }

       public override string ToString()
       {
           return $"{this.streetAddress}\n{this.city}, {this.stateProvince} {this.country}";
       }

       public string StreetAddress { get => streetAddress; set => streetAddress = value; }
       public string City { get => city; set => city = value; }
       public string StateProvince { get => stateProvince; set => stateProvince = value; }
       public string Country { get => country; set => country = value; }
   }
}