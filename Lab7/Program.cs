using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool more = true;
            while (more == true)
            { 

                List<Students> name = new List<Students>();
                name.Add(new Students(1, "Molly Guthrie", "Rockford, MI", "noodles"));
                name.Add(new Students(2, "Michelle Jokish Polo", "Ecuador", "spaghetti"));
                name.Add(new Students(3, "Rebecca Allard", "Charlevoix, MI", "noodles"));
                name.Add(new Students(4, "Brianna Jael", "Fairfield, CA", "gumbo"));
                name.Add(new Students(5, "Tammy Cole", "Grand Rapids, MI", "sushi, Maru Sushi to be exact."));
                name.Add(new Students(6, "Lauren Babcock", "Plainwell, MI", "cheeseburgers"));
                name.Add(new Students(7, "Karina Lopez", "Holland, MI", "tacos"));
                name.Add(new Students(8, "Anel Guel", "Juarez, also Grand Rapids, MI", "pizza"));
                name.Add(new Students(9, "Tommy Waalkes", "Raleigh, NC", "Indian red curry"));
                name.Add(new Students(10, "Lisa Dewey", "Los Angeles, CA", "mushroom masala dosa"));
                name.Add(new Students(11, "Jonaca Hudson", "Lansing, MI", "sushi"));
                name.Add(new Students(12, "Tanvi Sathe", "India", "chicken biryani"));

            
            

                Console.WriteLine("Welcome to our C# class. Which student would you like to learn about? (enter a number between 0-11)");
                int input = Int32.Parse(Console.ReadLine());

                foreach (Students s in name)
                {
                    int indexNumber = s.GetIndex();

                    if (indexNumber == input)
                    {
                        string studentName = s.GetName();
                        Console.WriteLine("Student " + indexNumber + " is " + name + ". What would you like to know, their hometown or favorite food?");
                        string input2 = Console.ReadLine();
                        input2 = input2.ToLower();

                        foreach (Students t in name)
                        {
                            string favFood = s.GetFood();
                            string hometown = s.GetCity();

                            if (input2 == "food")
                            {
                                Console.WriteLine(name + "'s favorite food is " + favFood + ".");
                            }
                            else if (hometown == "hometown")
                            {
                                Console.WriteLine(name + "is from " + hometown + ".");

                            }
                        }
                    }
                   /* while (!int.TryParse(indexNumber, out int num) || num > 12)
                    {
                        Console.WriteLine("Not a valid index number. Please insert a number between 0-11");
                    }*/
                    Console.WriteLine("Would you like to learn more? (y/n)");
                    string answer = Console.ReadLine();
                    answer = answer.ToLower();

                    if (answer != "y")
                    {
                        more = false;
                        Console.WriteLine("Ok, Buh-Bye.");
                    }
                }
            }

        }
    }
}
