using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Package and Labeler";
        job1._company = "UPS";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Police Officer";
        job2._company = "NYPD";
        job2._startYear = 2018;
        job2._endYear = 2024;


        Resume myresume = new Resume();
        myresume._name = "Andrew Hilton";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        myresume.Display();



      

    }
}