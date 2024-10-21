//Declaring enum lists

using System.ComponentModel;


//Making switch statements
public static class CoffeeSelector
{
    public enum Countries
    {
        Columbia = 1,
        Brazil = 2,
        Venezuela = 3,
        Kenya = 4,
        Ethiopia = 5,
        Nicaragua = 6,
        [Description("Costa Rica")] CostaRica = 7
    };

    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    public static void ToCountrySwitch(string country)
    {
        var res = "";
        switch (country)
        {
            case "MONDAY":
                res = "Columbia";
                break;
            case "TUESDAY":
                res = "Brazil";
                break;
            case "WEDNESDAY":
                res = "Venezuela";
                break;
            case "THURSDAY":
                res = "Kenya";
                break;
            case "FRIDAY":
                res = "Ethiopia";
                break;
            case "SATURDAY":
                res = "Nicaragua";
                break;
            case "SUNDAY":
                res = "Costa Rica";
                break;
            default:
                res = "";
                break;
        }
        if (res == "") {
            Console.WriteLine("Day not found.");
        } else
        {
            Console.WriteLine($"Today we will be drinking delicious coffee from {res}.");
        };
    }
    public static void Main()
    {
        var monday = (Countries)1;
        var tuesday = (Countries)2;

        Console.WriteLine($"On Monday we drink coffee from {monday}");
        Console.WriteLine($"On Tuesday we drink coffee from {tuesday}");

        Console.WriteLine("What day of the week is it today?");

        var today = Console.ReadLine().ToUpper();
        CoffeeSelector.ToCountrySwitch(today);
    }
}
