using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please write your Grade Percentage");
        string grade = Console.ReadLine();
        int Gradenumber = int.Parse(grade);
        String Letter = "";

        

        if(Gradenumber >= 90)
        {
            Letter = "A";
        }
        else if (Gradenumber >= 80)
        {
            Letter = "B";
        }
        else if (Gradenumber >= 70 )
        {
            Letter = "C";
        }
        else if (Gradenumber >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"your Grade is {Letter}");

        if (Letter == "D" || Letter == "F")
        {
            Console.WriteLine("You did not PASS");
        }

        else
        {
            Console.WriteLine("Congrats You did PASS");
        }



    }
}