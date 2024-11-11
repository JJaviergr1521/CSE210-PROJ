using System;

class Program
{
    static void Main(string[] args)
    {
       static void DisplayWelcome()

      {

        Console.WriteLine("Welcome to my program ;)");
      } 

        static string PromptUserName()

      {

        Console.WriteLine("Please enter your Name:");
        string name = Console.ReadLine();
        return name;


      }

       static int PromptUserNumber()
      {

        Console.WriteLine("Please enter your favorite Number:");
         int userNum = int.Parse(Console.ReadLine());
         return userNum;
      }

       static int SquareNumber(int InNumb)
      {

        InNumb = InNumb * InNumb;
        return InNumb;
      }


    static void DisplayResult(string User, int squaredN)
    {
        Console.Write($"{User}, the square of your number is {squaredN}");
    }


    DisplayWelcome();
    string UserIn = PromptUserName();
    int SquNum = PromptUserNumber();
    DisplayResult(UserIn,SquNum);







    }
}