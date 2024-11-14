using System;




class Program
{ 
    static void Main(string[]args)
{
    
  Job job1 = new Job ();
  job1._jobtitle = "Software engineer";
  job1._company = "Apple";
  job1._workedyears= 6;
  //job1.Display();
  
  Job job2 = new Job ();
  job2._jobtitle = "Building Management Systems";
  job2._company = "Us embassy";
  job2._workedyears= 3;

  Resume resume = new Resume ();
  resume._pName = "Javier Gutierrez";
  resume._jobs.Add(job1);
  resume._jobs.Add(job2);
  resume.DisplaR();



}
}