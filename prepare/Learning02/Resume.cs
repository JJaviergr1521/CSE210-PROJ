using System;

public class Resume
{
    public string _pName;
    public List<Job> _jobs = new List<Job>();



    public void DisplaR()
    {
        Console.WriteLine($"Name: {_pName}");
        Console.WriteLine("Jobs:");

      foreach (Job job in _jobs)
      {
        job.Display();
      }
        
        
        

    }
    
}
