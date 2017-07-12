using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for dictionary

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    {"A2", "Twizzlers" },
            //    {"A3", "Reeses" },
            //    {"A4", "Sour Patch Kids" }
            //};
            //foreach(KeyValuePair<string, string>item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            //using add method to add drinks

            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");

            //Counting the number of entries in the dictionary
            //Console.WriteLine(drinkMachine.Count);

            //foreach (KeyValuePair<int,string> drink in drinkMachine)
            //{
            //Console.WriteLine(drink.Key);
            //Console.WriteLine(drink.Value);
            //}

            //Create a dictionary for a theater coat check with 10 elements
            // the key will be a number and a value will be the coat style
            //print all the elements to the console
            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();

            //coatCheck.Add(1, " Leather");
            //coatCheck.Add(2, " Mink");
            //coatCheck.Add(3, " Rain jacket");
            //coatCheck.Add(4, " Camo");
            //coatCheck.Add(5, " Hoodie");
            //coatCheck.Add(6, " Sport coat");
            //coatCheck.Add(7, " Peacoat");
            //coatCheck.Add(8, " Trench");
            //coatCheck.Add(9, " Blazer");
            //coatCheck.Add(10, " Parka");

            //foreach (KeyValuePair<int,string> coat in coatCheck)
            //{
            //    Console.Write(coat.Key);
            //    Console.WriteLine(coat.Value);
            //}

            //Car valet with 10 cars, the key will be a customers last name and the
            //value will be the car make. print all the elements to the console
            Dictionary<string, string> cars = new Dictionary<string, string>();

            cars.Add("Jones", " Chevy");
            cars.Add("Smith", " Ford");
            cars.Add("Allen", " Dodge");
            cars.Add("Hanks", " Honda");
            cars.Add("Hunt", " Hyundai");
            cars.Add("Kendrick", " Jeep");
            cars.Add("Snow", " Volkswagen");
            cars.Add("Sheen", " Lincoln");
            cars.Add("Cruise", " Mercedes Benz");
            cars.Add("Roberts", " Infiniti");

            foreach (KeyValuePair<string,string> expensiveCars in cars)
            {
                Console.Write(expensiveCars.Key);
                Console.WriteLine(expensiveCars.Value);
            }

            

            //create a dictionary of 10 zoo animals, key will be the animal type
            //and the value will be the number of animals
            //Print the animal with the highest quantity to the console
            //remove the zoo animal with the lowest count

        }
    }
}
