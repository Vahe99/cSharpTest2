using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class student
    {
       
        public static int count = 0;

        public string name;
        public int age;
        public string nation;

        public student()
        {

        }
        public student(string _name, int _age, string _nation)
        {
            name = _name;
            age = _age;
            nation = _nation;

            print();
        }
        

        public void print()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Age - " + age);
            Console.WriteLine("nation - " + nation);
        }
        
    }
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0} nicw to meet you.", yourName);

            int age;
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 18)
            {
                Console.WriteLine("Then you are still a minor.", age);
            }
            else if(age >= 19 && age <= 40)
            {
                Console.WriteLine("You have a whole life ahead", age);
            }if(age >= 41)
            {
                Console.WriteLine("You look younger than {0}.", age);
            }
            
         

            string yourNation;
            Console.WriteLine("What is you nationality?");
            yourNation = Console.ReadLine();
            Console.WriteLine("Wow {0} are a very ancient nation!", yourNation);

            
            Console.WriteLine("Let's check how well you know the history of the {0} people.", yourNation);

            int number_1;
            Console.WriteLine("1)In what year did Armenia adopt Christianity?");
            do
            {
                number_1 = Convert.ToInt32(Console.ReadLine());
            } while (number_1 != 301);
            Console.WriteLine("Well done, {0} correct answer!", number_1);

            int number_2;
            Console.WriteLine("2)What year was the battle of Avarair?");
            do
            {
                number_2 = Convert.ToInt32(Console.ReadLine());
            } while (number_2 != 451);
            Console.WriteLine("Well done, {0} correct answer!", number_2);

            int number_3;
            Console.WriteLine("3)In what year did Mesrop Mashtots create the Armenian alphabet?");
            do
            {
                number_3 = Convert.ToInt32(Console.ReadLine());
            } while (number_3 != 405);
            Console.WriteLine("Well you answered all my questions. Congratulations!", number_3);

            Console.WriteLine();
            Console.WriteLine("Here are your detals.");
            student Name = new student(yourName, age, yourNation);
           
        }
    }
}
