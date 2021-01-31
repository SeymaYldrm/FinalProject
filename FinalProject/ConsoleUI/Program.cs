using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMomeryProductDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName); 
            }
        }
    }
}
