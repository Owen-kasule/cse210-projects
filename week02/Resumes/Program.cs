using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create a resume instance
        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}
     Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}