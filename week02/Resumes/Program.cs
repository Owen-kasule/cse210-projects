using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create the first job instance and set its member variables
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Step 2: Create the second job instance and set its member variables
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Step 3: Create a Resume instance and set its member variables
        Resume myResume = new Resume();
        myResume._personName = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Step 4: Display the resume and job details
        myResume.Display();
    }
}
