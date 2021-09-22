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


            Console.WriteLine(organiser.GetFullname());
            Console.WriteLine(invitee.GetFullname());


            Console.ReadLine();
        }
    }
}
