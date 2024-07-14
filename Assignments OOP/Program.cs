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

    #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.[Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable ]

    [Flags]
    enum Permissions
    {
        Read=1,
        Write=2,
        Delete=4,
        Execute=8
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

            //Person[] person =
            //{//Object intializer
            //    new Person("Ahmed",23),
            //    new Person("Ali",22),
            //    new Person("Mohmed",30)

            //};
            //foreach (var item in  person)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 3.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter your Season");
            //string? SeasonName=Console.ReadLine();
            //Season season;
            //if(Enum.TryParse(SeasonName,out season))
            //{ 
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Range: March To May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Range: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Range: Sep to Nov");
            //            break;
            //        case Season.Winter:
            //             Console.WriteLine("Range: Dec To Feb");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid SeasonName");
            //}



            #endregion

            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.[Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable ]
            //Permissions MyP= Permissions.Read;
            //Console.WriteLine(MyP);

            ////Add Permissions==> |
            //MyP |= Permissions.Write;
            //Console.WriteLine(MyP);

         

            ////Remove Permission ==>
            //MyP &= Permissions.Write;
            //Console.WriteLine(MyP);

            //if ((MyP & Permissions.Execute) == Permissions.Execute)
            
            //    Console.WriteLine("Permission is Exist");
            //else
            //    Console.WriteLine("Permission Not Exist");


            #endregion


        }
    }
}
