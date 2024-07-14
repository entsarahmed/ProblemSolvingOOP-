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
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //GetValues();-->Return Array of value for Enmum
            foreach (var item in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
