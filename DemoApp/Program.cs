using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string characterName = "John";
            int characterAge;
            characterAge = 30;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");

            characterName = "Mike";
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");


            string phrase = "This is a phrase";
            char grade = 'A';
            int age = -30;
            // float, double, decimal
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine(isMale);

            string newPhrase = "New Academy" + " is cool";
            Console.WriteLine(newPhrase.Length);
            Console.WriteLine(newPhrase.ToUpper());
            Console.WriteLine(newPhrase.Contains("New"));
            Console.WriteLine(newPhrase[3] == ' ');
            Console.WriteLine(newPhrase.IndexOf("Academy"));
            Console.WriteLine(newPhrase.Substring(4,7));// arg 2 is size

            Console.WriteLine(5/2.0);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Round(5.47));
           

            Console.WriteLine("\n\n");

            Console.Write("enter name: ");
            string name = Console.ReadLine();
            Console.Write("enter age: ");
            string newage = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + newage);



            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 9);*/


            /*Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine(num1 + num2);*/



            /*string color, pluralNoun, celebrity;

            Console.Write("enter color: ");
            color = Console.ReadLine();
            Console.Write("enter plural Noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("enter celebrity: ");
            celebrity = Console.ReadLine();
            
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("you are " + celebrity);*/



            /*int[] luckyNumbers = { 4, 8, 16, 32, 64 };
            luckyNumbers[2] = 20;
            Console.WriteLine(luckyNumbers[2]);

            string[] friends = new string[5];
            friends[0] = "new friend";
            Console.WriteLine(friends[2]);*/


            /*SayHi("Mark", 20);
            SayHi("John", 30);
            SayHi("Joe", 23);*/


            /*int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cube(number));*/


            /*bool isMale = true;
            bool isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine(" Tall Male");
            }
            else if(isMale && !isTall){
                Console.WriteLine("2");
            }
            else if(!isMale && isTall){
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("!Male or !Tall");
            }*/


            //Console.WriteLine(Getmax(3, 7, 7));


            /*Console.Write("no 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("operator: ");
            string op = Console.ReadLine();
            Console.Write("no 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(n1 + n2);
            }
            else if (op == "-")
            {
                Console.WriteLine(n1 - n2);
            }
            else if (op == "*")
            {
                Console.WriteLine(n1 * n2);
            }
            else if (op == "/")
            {
                Console.WriteLine(n1 / n2);
            }
            else
            {
                Console.WriteLine("invalid");
            }*/


            //Console.WriteLine(GetDay(50));


            /*int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int index2 = 6;
            do{
                Console.WriteLine(index2);
                index2++;
            }while (index2 <= 5) ;*/




            /*string secretWord = "password";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
            while (guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.WriteLine("enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if(outOfGuesses){
                Console.WriteLine("Lose");
            }
            else
            {
                Console.WriteLine("Win");
            }*/



            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNumbers = { 4, 8, 16, 32, 64 };
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }*/



            /*Book newBook = new Book();
            newBook.title = "Harry Potter";
            newBook.author = "J K Rowling";
            newBook.pages = 400;

            Book newBook2 = new Book
            {
                title = "Harry Potter part 2",
                author = "J K Rowling again",
                pages = 500
            };

            Console.WriteLine(newBook2.pages);*/



            /*Book newBook = new Book("Harry Potter", "J K Rowling", 140);
            newBook.Pages = 130;
            Console.WriteLine(newBook.Pages);*/


            Book newBook = new Book("Harry Potter", "J K Rowling", 400);
            Console.WriteLine(Book.count);
            Book newBook2 = new Book("Harry Potter part 2", "J K Rowling again", 450);
            Console.WriteLine(Book.count);




            Console.ReadLine();


        }


        static void SayHi(string user, int age)
        {
            Console.WriteLine("hello " + user + " your age is " + age);
        }

        static int cube(int number)
        {
            int result = number * number * number;
            return result;
        }

        static int Getmax(int n1, int n2, int n3)
        {
            int result;
            //result = Math.Max(n1, n2);
            if(n1 >= n2 && n1 >= n3)
            {
                result = n1;
            }
            else if(n2 >= n3 && n2 >= n1)
            {
                result = n2;
            }
            else
            {
                result = n3;
            }
            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wed";
                    break;
                case 4:
                    dayName = "Thurs";
                    break;
                case 5:
                    dayName = "Fri";
                    break;
                case 6:
                    dayName = "Sat";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }

            return dayName;
        }

    }
}
