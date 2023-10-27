using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOPSandArrays
{
    public class PS4arrayOfProductsClass
    {
        static void Main(string[] args)
        {
            PS2Products[] products = new PS2Products[5];//creating PS2Products class array instead of int array

            products[0] = new PS2Products();//creating array object

            products[0].productId = 101;
            products[0].productName = "bread";
            products[0].productPrice = 40;
            products[0].UnitOfMeasurement = "kilogram";
            products[0].productQuantity = 25;

            products[1] = new PS2Products();
            products[1].productId = 102;
            products[1].productName = "jam";
            products[1].productPrice = 35;
            products[1].UnitOfMeasurement = "grams";
            products[1].productQuantity = 250;

            products[2] = new PS2Products();
            products[2].productId = 103;
            products[2].productName = "veggies";
            products[2].productPrice = 60;
            products[2].UnitOfMeasurement = "kilogram";
            products[2].productQuantity = 1;

            products[3] = new PS2Products();
            products[3].productId = 104;
            products[3].productName = "fruits";
            products[3].productPrice = 300;
            products[3].UnitOfMeasurement = "kilogram";
            products[3].productQuantity = 1;

            products[4] = new PS2Products();
            products[4].productId = 105;
            products[4].productName = "biscuits";
            products[4].productPrice = 20;
            products[4].UnitOfMeasurement = "pack";
            products[4].productQuantity = 2;

            foreach (var product in products)
            {
                Console.WriteLine(product.productId);
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.UnitOfMeasurement);
                Console.WriteLine(product.productQuantity);

                Console.WriteLine("***********************************************************");

            }

            Console.ReadLine();
        }
    }
}
