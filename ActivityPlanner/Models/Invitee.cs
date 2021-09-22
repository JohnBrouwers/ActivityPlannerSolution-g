using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.Models
{
    class Invitee: Person
    {
        public Invitee(string surname): base(surname)
        {

        }

        public override string GetFullname() 
        {
            return $"{this.SurnamePrefix} {this.Surname}, {this.Firstname}";
        }
    }
}
