using System;

public class Job 
{
    public string _jobtitle ;
    public string _company ;
    public int _workedyears ;
    


    public void Display()
    {

       Console.WriteLine($"{_jobtitle} \n ({_company}) {_workedyears} years");

    }

    
}
