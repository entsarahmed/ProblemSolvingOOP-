namespace Assignments_OOP
{
    #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    #endregion

    #region 2. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
    struct Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }


        //Display Person Of Data
        public override string ToString()
        {
            return $"Person Name: {Name}, Person Age: {Age}";
        }
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //GetValues();-->Return Array of value for Enmum
            //foreach (var item in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            Person[] person =
            {//Object intializer
                new Person("Ahmed",23),
                new Person("Ali",22),
                new Person("Mohmed",30)

            };
            foreach (var item in  person)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
