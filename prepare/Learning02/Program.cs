using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2020;
        job1.DisplayJob();

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "HR";
        job2._startYear = 2002;
        job2._endYear = 2023;
        job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Leon Smith";
        myResume._jobs[0] = job1;
        myResume._jobs[1] = job2;
        myResume.DisplayResume();

    }
}