using System;

///Laborator 3.1
///

//class PosNegZero
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(" Input number: ");
//        int num=Convert.ToInt32(Console.ReadLine());
//        if (num > 0) { Console.WriteLine("The number is positive."); }
//        else if (num == 0) { Console.WriteLine("The number is equal to 0."); }
//        else
//        {
//            Console.WriteLine("The number is negative.");
//        }

//    }
//}


////laborator 3.2

//class SwitchGame
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Input number 1 to 4: ");
//        int num=Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Input number1:");
//        int num1=Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Input number2:");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        int sum = num1 + num2;
//        int dif = num1 - num2;
//        int pow = num1 * num2;
//        double div = num1 / num2;



//        switch (num)
//        {
//            case 1:
//                Console.WriteLine("The sum of two numbers is: "+ sum);
//                break;
//            case 2:
//                Console.WriteLine("The difference of two numbers is: " + dif);
//                break;
//            case 3:
//                Console.WriteLine("The power of two numbers is: " + pow);
//                break;
//            case 4:
//                Console.WriteLine("The quotient of two numbers is: " + div );
//                break;
//            default:
//                Console.WriteLine("Number must be 1-4: ");
//                break;



//        }
//    }
//}


////Laborator 3.3


//class ForLoop
//{
//    static void Main(string[] args)
//    {
//        for(int i = 2; i <= 20; i += 2)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


///Laborator 3.4
///

//class WhileLoop
//{
//    static void Main(string[] args)
//    {
//        Console.Write("For EXIT write exit: ");

//        string word = "";
//        while (word != "exit")
//        {
//            word = Console.ReadLine();

//            if (word != "exit")
//            {
//                Console.WriteLine("Hello!");
//                Console.Write("What is your name: ");

//            }
//            else {
//                Console.WriteLine("You are exit.");
//                break; }
//        }
//    }
//}

///Homework 3.1
///

//class PrimeNum
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Input number: ");
//        int num=Convert.ToInt32(Console.ReadLine());
//        if (num < 2)
//        {
//            Console.WriteLine("Not Prime");
//            return;
//        }
//        bool isPrime = true;

//        for (int i=2; i < num; i++)
//        {
//            if (num % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }

//        if (isPrime)
//            Console.WriteLine("Prime");
//        else
//            Console.WriteLine("Not Prime");
//    }
//}



////homework 3.2
//using System;

//class SumNumbers
//{
//    static void Main(string[] args)
//    {
//        Console.Write("input N: ");
//        int N = Convert.ToInt32(Console.ReadLine());

//        int sum = 0;

//        for (int i = 1; i <= N; i++)
//        {
//            sum += i; 
//        }

//        Console.WriteLine("The sum is: " + sum);
//    }
//}


///homework 3.3
///
//using System;

//class MonthSwitch
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter the month number (1-12): ");
//        int monthNumber = Convert.ToInt32(Console.ReadLine());

//        switch (monthNumber)
//        {
//            case 1:
//                Console.WriteLine("January");
//                break;
//            case 2:
//                Console.WriteLine("February");
//                break;
//            case 3:
//                Console.WriteLine("March");
//                break;
//            case 4:
//                Console.WriteLine("April");
//                break;
//            case 5:
//                Console.WriteLine("May");
//                break;
//            case 6:
//                Console.WriteLine("June");
//                break;
//            case 7:
//                Console.WriteLine("July");
//                break;
//            case 8:
//                Console.WriteLine("August");
//                break;
//            case 9:
//                Console.WriteLine("September");
//                break;
//            case 10:
//                Console.WriteLine("October");
//                break;
//            case 11:
//                Console.WriteLine("November");
//                break;
//            case 12:
//                Console.WriteLine("December");
//                break;
//            default:
//                Console.WriteLine("Invalid input, please enter a number between 1 and 12.");
//                break;
//        }
//    }
//}



///homework 3.4
///


//class GuessTheNumber
//{
//    static void Main(string[] args)
//    {
//        Random random = new Random();
//        int numberToGuess = random.Next(1, 101);
//        int userGuess = 0;

//        Console.WriteLine("Guess the number between 1 and 100:");

//        while (userGuess != numberToGuess)
//        {
//            Console.Write("Enter your guess: ");
//            userGuess = Convert.ToInt32(Console.ReadLine());

//            if (userGuess < numberToGuess)
//            {
//                Console.WriteLine("Too low, try a higher number.");
//            }
//            else if (userGuess > numberToGuess)
//            {
//                Console.WriteLine("Too high, try a lower number.");
//            }
//            else
//            {
//                Console.WriteLine("Correct! Congratulations!");
//            }
//        }
//    }
//}
