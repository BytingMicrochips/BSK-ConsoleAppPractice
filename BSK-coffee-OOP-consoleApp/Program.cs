// make model folder
// make base class model  'CoffeeData'
// extend base class with different models e.g. 'ColumbianCoffee : CoffeeData'
// use dictionaries and lists to store data in models


// declaring a list and adding items to it
// list length can be changed during code execution
// items can be overwritten, added, removed



public class MenuBase
{
    List<string> drinkOptions = new List<string>();
    public MenuBase()
    {
    drinkOptions.Add("Americano");
    drinkOptions.Add("Latte");
    drinkOptions.Add("Cappuccino");
    drinkOptions.Add("Espresso");
    drinkOptions.Add("Flat white");
    drinkOptions.Add("Macchiato");
    drinkOptions.Add("Mocha");
    drinkOptions.Add("Cold brew");
    drinkOptions.Add("Affogato");
    }

    public void Main()
    {

    }
    public void EditDrinks()
    {
drinkOptions.Remove("Macchiato");
drinkOptions.Insert(2, "Batch brew");

    }
}

// editing list

// making a foreach loop to write all drinks
Console.WriteLine("Drink options:");
foreach(string drink in drinkOptions) 
{  
    Console.WriteLine(drink);
}

// declaring an array of objects
// array has fixed size, won't compile if size is exceeded
// items can be overwritten 
string[] milkOptions = new string[4];
milkOptions[0] = "dairy";
milkOptions[1] = "oat";
milkOptions[2] = "soy";
milkOptions[3] = "almond";

// getting length of  list
Console.WriteLine(drinkOptions.Count);

// getting length of array
Console.WriteLine(milkOptions.Length);

// find index of item in list
Console.WriteLine(drinkOptions.IndexOf("Flat white"));

// overwriting array items
milkOptions[0] = "goat";
milkOptions[0] = "cow";

// making a foreach loop to write all milks
    Console.WriteLine("Milk options:");
foreach (string item in milkOptions)
{
    Console.WriteLine(item);
}

// selecting from array and list using index 
Console.WriteLine($"I\'ll have an {drinkOptions[0]} with {milkOptions[2]} milk please");

