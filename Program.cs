using System;
using static System.Console;

namespace Group_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Create a class store

            //Create a class item

            //Create the store

            Store store = new Store("Jewel");

            //Create 5 items

            Item milk = new Item("Milk", 3.49);
            Item soda = new Item("Soda", 2.50);
            Item cereal = new Item("Cereal", 4.99);
            Item iceCream = new Item("Ice cream", 3.45);
            Item pizza = new Item("Pizza", 9.99);

            //Create item array from 5 items

            //string[] fruites = new string[] { "apple", "orange", "banana", "pine apple", "dragon fruit" };
            Item[] items = new Item[] { milk, soda, cereal, iceCream, pizza };

            //Show the user all of the items in the store

            WriteLine($"Welcome to {store.StoreName}");
            WriteLine($"Please pick an item (a number between 1 and {items.Length})");
            //Loop throught fruits to show user valid fruit options
            for (int i = 0; i < items.Length; i++)
            {
                //A local variable is used for presentation purposes. We need increase it by 1 to accomadate for 0 based indexing
                int labelNumber = i + 1;
                //Show the furuit with a label
                WriteLine($"{labelNumber}) {items[i].ItemName} {items[i].ItemPrice:C}");
            }

            //Let the user pick an item

            int choice = 0;
            //Get the choice from the user
            choice = Convert.ToInt32(ReadLine());
            //Make sure user input is a valid choice 
            if (choice > 0 && choice <= items.Length)
            {
                //Decrease the of choice by 1 to accomadate for 0 based indexing
                int labelNumber = choice - 1;
                //Show the user their selection
                WriteLine($"Thank you for choosing {items[labelNumber].ItemName} it will cost you {items[labelNumber].ItemPrice:C}");
            }
            else
            {
                WriteLine("Please enter a valid value");
            }

            //Make sure the user's choice is a valid choice

            //Show the price of the item the user chooses
        }           
    }
}
