using System;
using System.Text;

namespace ActivityPlanner.Models
{
    internal class Person: INamable, IComparable<Person>
    {
        //field: data container
        private string _surname;

        //Auto implemented property:
        public string Firstname { get; set; }

        //Expression bodied member(property):
        public string Surname { 
            get => this._surname;
            set => this._surname = value; 
        }

        //Fully implemented property:
        private string surnamePrefix;
        public string SurnamePrefix
        {
            get { return surnamePrefix; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("FOUT!!!!");
                }    
                surnamePrefix = value; 
            }
        }


        //contructor
        public Person(string surname)
        {
            this.Surname = surname;
        }

        public virtual string GetFullname() 
        {
            return (Firstname + (" " + SurnamePrefix).TrimEnd() + " " + Surname).Trim();
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(Person other)
        {
            return this.Surname.CompareTo(other.Surname);
        }
    }
}