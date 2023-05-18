using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // Business:Concrete:ProductManager'den kullanmak üzere sınıf oluşturduk
            // Ve parametre olarak verilere ulaşmak için EfProductDal new'ledik.

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }





        }
    }
}