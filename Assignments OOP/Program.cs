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
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    #endregion
    #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    #region 6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point X: {X}, Point Y:{Y}";

        }



        #endregion
        internal class Program
        {
            #region 6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            static Point CreatePoint()
            {
                Point point = new Point();
                Console.WriteLine("X: ");
                point.X=double.Parse(Console.ReadLine());
                Console.WriteLine("Y: ");
                point.Y=double.Parse(Console.ReadLine());
                return point;
            }

            static double Distance(Point P1, Point P2)
            {
                return Math.Sqrt(Math.Pow(P1.X-P2.X, 2)+(Math.Pow(P1.X-P2.Y, 2)));

            }

            #endregion

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


                #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
                //Console.WriteLine("Enter Your Colors");
                //string InputColors=Console.ReadLine();
                //Colors colors;
                //if(Enum.TryParse(InputColors,out colors))
                //{
                //    Console.WriteLine("Primary Color");
                //}
                //else
                //{
                //    Console.WriteLine("Not Primary Color");
                //}


                #endregion

                #region 6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
                Console.WriteLine("Enter The Data For the 1st Point");
                Point point1 = CreatePoint();

                Point  point2 = CreatePoint();

                Console.WriteLine($"Distance = {Distance(point1,point2)}");

                #endregion

                #region 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
                Person[] person = new Person[3];
                for(int i=0; i<3; i++)
                {
                    string name;
                    do
                    {
                        Console.WriteLine($"Enter your Name {i+1}");
                        name = Console.ReadLine();


                    } while (string.IsNullOrWhiteSpace(name));
                    person[i].Name = name;
                    int Age;
                    bool Flag;
                    do
                    {
                        Console.WriteLine($"Enter Your Age {i+1}");
                        Flag= int.TryParse(Console.ReadLine(), out Age);
                    } while (!Flag);
                    person[i].Age = Age;
                }
                Person Oldest = person[0];
                for (int i = 0; i<3; i++)
                    if (Oldest.Age<person[i].Age)
                        Oldest= person[i];
                Console.WriteLine(Oldest);
                #endregion

            }
        }
    }
}