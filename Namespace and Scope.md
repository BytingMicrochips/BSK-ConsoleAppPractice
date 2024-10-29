C# Namespace and Scope Fundamentals 

- Namespaces are used to organise classes within C#
- Think of them as labels for a filing system
- In the example below, 'System' is a namespace and 'Console' is a class  within that namespace:
     System.Console.WriteLine("Hello World!");
- This can be refactored with the 'using' keyword to save writing 'System' every time we want to call this very common class and it's methods:
    using System;
    Console.WriteLine("Hello World!");

- Implicit using directives
    - In .NET 6, some of the most common namespaces are included by default - these are refered to as the 'implicit global using directives'
    - Which global using directives are implicitly included depends on which .NET SDK(s) the project is using
    - SDK stands for 'software development kit'
    - Every .NET project includes the Microsoft.NET.Sdk, which adds the following default namespaces as implicit 'global using' directives:
        - System, System.Collections.Generic, System.IO, System.Linq, System.Net.Http, System.Threading, System.Threading.Tasks
    - Another project that is built using Microsoft.NET.Sdk.Web will inherit all of the above namespaces, plus new ones specific to this SDK

- Controlling Scope
    - Using namespaces helps to limit or control the scope of a class
    - You declare a namespace for a single class like this:
    
    namespace ExampleNamespace
    {
        class ExampleClass 
        {
            public void ExampleMethod()
            {
                System.Console.WriteLine("This printout comes from a method, inside a class, inside a namespace")
            }
       }
    }
    
    - You can also declare a namespace for a whole file like this: 
    
    namespace ExampleNamespace2;
    
    class DifferentExampleClass
    {
        public void DifferentExampleMethod()
        {
            System.Console.WriteLine("This printout is from a method, inside a class, namespaced at the top of the file")
        }
    }

    - All subsequent classes made inside this file will be contained within the namespace 'ExampleNamespace2'
    - You can set a global namespace as the 'root' to base all the more specific ones off
    - global::System is always the .NET System namespace