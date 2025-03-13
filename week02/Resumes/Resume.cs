using System;
public class Resume
{
    public string _name = "Andrew Hilton";
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine("Name: " + _name);
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
 
}