using System;
using System.Collections.Generic;
using System.Data;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // List - Practice

            List<string> foodChain = new List<string>();

            foodChain.Add("Jollibee");
            foodChain.Add("McDonalds");
            foodChain.Add("KFC");
            foodChain.Remove("KFC");
            Console.WriteLine(foodChain.Contains("Jollibee"));

            foreach (string store in foodChain)
            {
                Console.WriteLine(store);
            }


            Console.ReadKey();
        }
    }
}