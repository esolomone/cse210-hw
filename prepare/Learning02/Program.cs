using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Intelligence Specialist";
        job1._company = "United States Navy";
        job1._startYear = 2012;
        job1._endYear = 2020; 

        Job job2 = new Job();
        job2._jobTitle = "Protective Security Officer";
        job2._company = "FBI";
        job2._startYear = 2017;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Edward Murray";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        



    }
}