using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPlanner.Models
{
    class Activity: INamable
    {
        public string Title { get; set; }

        public DateTime Date{ get; set; }

        public string GetFullname()
        {
            return $"{Title} - {Date.ToShortDateString()}";
        }
    }
}
