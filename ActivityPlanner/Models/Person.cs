using System;

namespace ActivityPlanner.Models
{
    internal class Person
    {
        //field: data container
        private string surname;

        //Auto implemented property:
        public string Firstname { get; set; }

        //Expression bodied member(property):
        public string Surname { 
            get => this.surname;
            set => this.surname = value; 
        }

        //Fully implemented property:
        private string surnamePrefix;
        public string SurnamePrefix
        {
            get { return surnamePrefix; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }    
                surnamePrefix = value; 
            }
        }


        //contructor
        public Person(string surname)
        {
            this.Surname = surname;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}