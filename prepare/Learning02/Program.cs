using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._company = "Goldman Sachs";

        job1._jobTitle = "Software Engineer";

        job1._startYear = 2023;

        job1._endYear = 2030;



        Job job2 = new Job();

        job2._company = "Microsoft";

        job2._jobTitle = "Cyber Analyst";

        job2._startYear = 2030;

        job2._endYear = 2040;

        job1.DisplayJobDetails();

        job2.DisplayJobDetails();


    }
}




//person1 = new Person();
 //   person1._givenName = "Emma";
 //   person1._familyName = "Smith";
 //   person1.ShowWesternName();

 //   person2 = new Person();
 //   person2._givenName = "Joseph";
 //   person2._familyName = "Smith";
 //   person2.ShowWesternName();