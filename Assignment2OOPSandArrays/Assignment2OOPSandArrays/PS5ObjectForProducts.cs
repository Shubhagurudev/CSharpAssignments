﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2OOPSandArrays
{
    public class PS5ObjectForProducts
    {
        static void Main(string[] args)
        {
            PS5Products bread = new PS5Products();
            bread.productId = 101;
            bread.productName = "bread";
            bread.productPrice = 40;
            bread.UnitOfMeasurement = "kilogram";
            bread.productQuantity = 25;
            Console.WriteLine(bread.productId);
            Console.WriteLine(bread.productName);
            Console.WriteLine(bread.productPrice);
            Console.WriteLine(bread.UnitOfMeasurement);
            Console.WriteLine(bread.productQuantity);


            Console.WriteLine("***********************************************************");

            PS5Products jam = new PS5Products();
            jam.productId = 102;
            jam.productName = "jam";
            jam.productPrice = 35;
            jam.UnitOfMeasurement = "grams";
            jam.productQuantity = 250;
            Console.WriteLine(jam.productId);
            Console.WriteLine(jam.productName);
            Console.WriteLine(jam.productPrice);
            Console.WriteLine(jam.UnitOfMeasurement);
            Console.WriteLine(jam.productQuantity);


            Console.WriteLine("***********************************************************");

            PS5Products veggies = new PS5Products();
            veggies.productId = 103;
            veggies.productName = "carrot";
            veggies.productPrice = 60;
            veggies.UnitOfMeasurement = "kilogram";
            veggies.productQuantity = 1;
            Console.WriteLine(veggies.productId);
            Console.WriteLine(veggies.productName);
            Console.WriteLine(veggies.productPrice);
            Console.WriteLine(veggies.UnitOfMeasurement);
            Console.WriteLine(veggies.productQuantity);


            Console.WriteLine("***********************************************************");

            PS5Products fruits = new PS5Products();
            fruits.productId = 104;
            fruits.productName = "fruits";
            fruits.productPrice = 300;
            fruits.UnitOfMeasurement = "kilogram";
            fruits.productQuantity = 1;
            Console.WriteLine(fruits.productId);
            Console.WriteLine(fruits.productName);
            Console.WriteLine(fruits.productPrice);
            Console.WriteLine(fruits.UnitOfMeasurement);
            Console.WriteLine(fruits.productQuantity);


            Console.WriteLine("***********************************************************");

            PS5Products biscuits = new PS5Products();
            biscuits.productId = 105;
            biscuits.productName = "biscuits";
            biscuits.productPrice = 20;
            biscuits.UnitOfMeasurement = "pack";
            biscuits.productQuantity = 2;
            Console.WriteLine(biscuits.productId);
            Console.WriteLine(biscuits.productName);
            Console.WriteLine(biscuits.productPrice);
            Console.WriteLine(biscuits.UnitOfMeasurement);
            Console.WriteLine(biscuits.productQuantity);
            Console.ReadLine();

            Console.WriteLine("***********************************************************");

        }
    }
}
