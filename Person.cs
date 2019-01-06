using System;

namespace lab1
{
    public class Person
    {

        public string name { get; set; }
        public string surname { get; set; }
        protected DateTime date_of_birth;

        public int year_of_birth
        {
            get { return this.date_of_birth.Year; }

            set
            {
                int year = value;
                int month = this.date_of_birth.Month;
                int day = this.date_of_birth.Day;

                this.date_of_birth = new DateTime(year, month, day);
            }
        }

        public Person()
        {
            this.name = "Sasha";
            this.surname = "Shlyapik";
            this.date_of_birth = new DateTime(1999, 10, 27);
        }

        public Person(string name, string surname, string date_of_birth)
        {
            this.name = name;
            this.surname = surname;
            this.date_of_birth = Convert.ToDateTime(date_of_birth);
        }

        public int getPersonAge()
        {
            int age = 0;
            String[] now = DateTime.Now.ToShortDateString().Split('.');
            String[] birth = this.date_of_birth.ToShortDateString().Split('.');
            for (int i = 2; i >= 0; i--)
            {
                if (Int32.Parse(now[i]) > Int32.Parse(birth[i]))
                {
                    age += Int32.Parse(now[i]) - Int32.Parse(birth[i]);
                }
                else
                {
                    age -= 1;
                    break;
                }
            }
            Console.WriteLine(age);
            return age;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
            Console.WriteLine("Date of birth: " + this.date_of_birth.ToLongDateString());
        }

        public override bool Equals(object obj)
        {
            Person item = (Person)obj;
            return String.Equals(this.name, item.name) &&
                   String.Equals(this.surname, item.surname) &&
                   String.Equals(this.date_of_birth.ToShortDateString(), item.date_of_birth.ToShortDateString());
        }

        public override int GetHashCode()
        {
            int result = this.name.Length + this.surname.Length;
            result += this.date_of_birth.ToLongDateString().Length;
            return result;
        }
    }
}