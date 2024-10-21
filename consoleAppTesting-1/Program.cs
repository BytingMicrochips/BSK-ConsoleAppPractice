//Example WriteLine
Console.WriteLine("Hello, World!");

//Example variable declaration
string master = "Big Mike";
Console.WriteLine("Hello, Big Mike!");

//Declare string list
var workloadResponses = new List<string>()
{
    "We should try find some work to do...",
    "It should be an easy week",
    "Praise be to coffee and checking the docs every 2 minutes!",
        "So much to do! Coffee on the keyboard!",
        "We are going to need a live in barista to help us get through this! *typing noises intensify*",
        "We are going to need more devs, coffee won't help us out of this much work."
};

//Example interpolation
Console.WriteLine($"Hello {master}");


int amount = 21;
string fuel = " coffees";

//Example concatenate
Console.WriteLine("Softwarehaus BSK runs on a minimum of " + amount + fuel + " a week.");

//Example calculation 
int devs = 3;
int workdays = 5;
double caffeinationFactor = 1.4;

Console.WriteLine(devs * workdays * caffeinationFactor);

//Basic modulo and updating variable
caffeinationFactor = caffeinationFactor + 1.2;

double trueValue = devs * workdays * caffeinationFactor;
double wholeCoffees = trueValue - (trueValue % 1);
Console.WriteLine($"True value: { trueValue}  Whole coffees: { wholeCoffees}");


//Rounding numbers
double roundedCoffees = Math.Round(trueValue);
double ceilingCoffees = Math.Ceiling(trueValue);
double floorCoffees = Math.Floor(trueValue);
Console.WriteLine($"roundedCoffees = {Math.Round(trueValue)}");
Console.WriteLine($"CeilingCoffees = {Math.Ceiling(trueValue)}");
Console.WriteLine($"floorCoffees = {Math.Floor(trueValue)}");

//WriteLine with line breaks
Console.WriteLine($"roundedCoffees = {Math.Round(trueValue)} \nCeilingCoffees = {Math.Ceiling(trueValue)} \nfloorCoffees = {Math.Floor(trueValue)}");

//User input
Console.WriteLine("Input desired caffeination factor:");
caffeinationFactor = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"With caffeination factior of {caffeinationFactor}, Softwarehaus BSK requires {devs * workdays * caffeinationFactor} coffees to maintain productivity.");

//Conditional statements
Console.WriteLine("How many projects do we have this week?");
int totalProjects = int.Parse(Console.ReadLine());

if( totalProjects == 0)
{
    caffeinationFactor = 1;
    Console.WriteLine(workloadResponses[0]);
}
if  (totalProjects > 0 & totalProjects <= 4)
{
    caffeinationFactor = 1.4;
    Console.WriteLine(workloadResponses[1]);
}
if (totalProjects > 4 & totalProjects <= 8)
{
    caffeinationFactor = 1.9;
    Console.WriteLine(workloadResponses[2]);
}
if (totalProjects > 8 & totalProjects <= 12)
{
    caffeinationFactor = 2.5;
    Console.WriteLine(workloadResponses[3]);
}
if (totalProjects > 12 )
{
    caffeinationFactor = 3.9;
    Console.WriteLine(workloadResponses[4]);
}
if (totalProjects >= 15)
{
    Console.WriteLine(workloadResponses[5]);
}
if (totalProjects < 15)
{
Console.WriteLine($"This week BSK softwarehaus needs a minimum of {Math.Floor(trueValue)} coffees to function.");
}


//Add to a list

workloadResponses.Add( "Panic!");

