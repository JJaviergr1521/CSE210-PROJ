using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        string flag = "true";





        while (flag == "true")

        {


            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string numerInstr = Console.ReadLine();
            int numberinteg = int.Parse(numerInstr);
            int maxNum = 0;




            if (numberinteg == 0)
            {
                break;
            }

           
            else
            {


                numbers.Add(numberinteg);



                {



                    int added = 0;
                    
                    foreach (int number in numbers)

                        added += number;
                        float avg = ((float)added) / numbers.Count;
                        

                     Console.WriteLine($"this is the sum {added}");
                     Console.WriteLine($"this is the average {avg}");

                     if (numberinteg > numbers[0])

                    {   
                        
                        maxNum = numberinteg;

                        Console.WriteLine($"this is the max number {maxNum}");



                    }





                }

           



            }

        }









    }
}