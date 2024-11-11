using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)


    {

        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(1, 99);
        string InputNum = "";
        int NumberGuess = 0;
        
        string flag = "true";
        

        
        //Console.WriteLine("Guess");
       
    

        while (flag == "true")

        {   
            Console.WriteLine("Guess the magic number");
            InputNum = Console.ReadLine();
            NumberGuess = int.Parse(InputNum);

             if ( RandomNumber> NumberGuess)
        {   Console.WriteLine(RandomNumber);
            Console.WriteLine("Higher");
        }
        else if (RandomNumber < NumberGuess)
        {   Console.WriteLine(RandomNumber);
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine(RandomNumber);
            Console.WriteLine("Yep that is the magic number");
            Console.WriteLine("Do you want to play again? yes/no");
            string Playagain = Console.ReadLine();
            if(Playagain == "yes")
            {
                flag = "true";
            }
            else
            {
                flag = "false";
            }
            
        }

            
            

        } 

    
    }
}