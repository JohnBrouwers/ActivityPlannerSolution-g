using ActivityPlanner.Data;
using ActivityPlanner.Models;
using System;

namespace ActivityPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            Organiser organiser = new Organiser("Schriever") { Firstname = "Jan"};

            Invitee invitee = new Invitee("Hu") { Firstname = "Feixiang", SurnamePrefix = "van der" };

            Activity activity = new Activity() { Title = "Sjoelen", Date = DateTime.Now };

            //Console.WriteLine(organiser.GetFullname());
            //Console.WriteLine(invitee.GetFullname());
            PrintNamables(organiser);
            PrintNamables(invitee);
            PrintNamables(activity);

            GenericRepository<Activity> repository = new GenericRepository<Activity>();
            repository.Add()


            Console.ReadLine();
        }

        static void PrintNamables(INamable namable) 
        {
            Console.WriteLine(namable.GetFullname());
        }
    }
}
