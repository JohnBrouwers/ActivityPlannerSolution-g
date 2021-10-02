using ActivityPlanner.Data;
using ActivityPlanner.Models;
using System;
using System.Collections.Generic;

namespace ActivityPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //INamableInterfaceSampleCode();
            //GenericsSampleCode();
            //IComparableInterfaceSampleCode();


            Console.ReadLine();
        }

        private static void IComparableInterfaceSampleCode()
        {
            var invitees = new List<Invitee>() {
                new Invitee("Pietersen"),
                new Invitee("Jansen"),
                new Invitee("Klaasen")
            };

            //This sort method uses the implemented IComparable.Compare method from the Person class (as a default sort by Surname)
            invitees.Sort();

            foreach (var invitee in invitees)
            {
                Console.WriteLine(invitee.Surname);
            }
        }

        private static void INamableInterfaceSampleCode()
        {
            Organiser organiser = new Organiser("Jansene") { Firstname = "Jan" };

            Invitee invitee = new Invitee("Klaassen") { Firstname = "Klaas", SurnamePrefix = "van der" };

            Activity activity = new Activity() { Title = "Sjoelen", Date = DateTime.Now };

            //Console.WriteLine(organiser.GetFullname());
            //Console.WriteLine(invitee.GetFullname());
            PrintNamables(organiser);
            PrintNamables(invitee);
            PrintNamables(activity);

        }

        static void PrintNamables(INamable namable) 
        {
            Console.WriteLine(namable.GetFullname());
        }

        private static void GenericsSampleCode()
        {
            System.Collections.Generic.List<Organiser> organisers = null;

            GenericRepository<Activity> repositoryA = new GenericRepository<Activity>();
            repositoryA.Add(new Activity());

            GenericRepository<Organiser> repositoryO = new GenericRepository<Organiser>();
            repositoryO.Add(new Organiser("Jansen"));

        }

    }
}
