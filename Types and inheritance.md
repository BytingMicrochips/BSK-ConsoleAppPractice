C# Type Fundamentals and Inheritance


- c# is strictly typed
	- all variables are given a type
	- the compiler prevents operations being carried out when types are incompatible (eg int and bool)
	- types  of method params and return values are specified in the method declaration
	- example method below will take an integer input (stated in params) and is expecting a string return (stated after 'public')
	
	public string ThisMethod(int input)
		{
		  returns 'something stringy'
		}
	- full list of c# types from microsoft docs: https://shorturl.at/jd0Bx
	
- type conversion
	- declared variables can not have redeclared type, but can be converted
	- Implicit conversions: any type conversion that does not risk losing data will be done automatically by the compiler (eg int16 to int32, int to long)
	- Explicit conversions: type conversions that may cause data loss need to be 'cast' in the written code (long to int)
	- Casts can be achieved using either user defined functions or helper classes (eg System.Convert class or Int32.Parse method)

- inheritance
	- types can derive from other types, known as 'base types'. The derived type will inherit the methods, properties and member of the base type (with exceptions)
	- inheritance and layers of derivation exist multiple times, wiith methods, properties  and members being passed down the chain to lower level derived types according to commoon type system, CTS (see images.commonTypeSystemCTS.png)
	- look at images.valueTypesReferenceTypesCTS.png to help picture the object structure of how types and inheritance all derive from System.Object in CTS

- user defined types
	- the user can define a custom type with its own methods, properties and other data stored within
	- this may be in the form of a 'class', 'interface' or 'struct'
	- each of these types is a blueprint that when instanciated will create an object to then be called upon or manipulated when the code runs
	- the runtime code may create multiple instances of the same class, interface or struct to exist at the same time for different purposes

	- classes
		- a class is a reference type
		- objects created by instanciating a class are references to the memory allocated to store the class
		- all variables referencing a specific class refer back to the same original class
		- changes made to one variable WILL be reflected in all others because of this (mutation)
		- generally used for complex data structures intended to be modified after creation

	- struct
		- a struct is a value type
		- objects created by assigning a struct to a variable are copies of the original data (take up memory, are NOT references)
		- changes made to oen variable WILL NOT be reflected in any others (do not mutate the original struct)
		- generally used for small data structures not intended to be modified after creation
		
	- record types
		- these can be either references (record class) or value types (record struct) depending on user definition
		- mutation behaviour will behave accordingly 
		- generally used for data not intended to be modified after creation
		- record types contain members that are synthesised when the compiler runs the written code

- value types and heirachy
	- all value types derive from System.ValueType, which derives from System.Object
	- all value types are either structs or enums (bottom left of images.valueTypesReferenceTypesCTS.png)
	- value types are 'sealed' meaning you can not further derive from them
	- the heirachy structure dictaates structs can not be defined to inherit from other structs(they are equal level)
	- the heirachy structure dictaates structs can not be defined to inherit from user defined classes (user defined classes are not derived from System.ValueType)
	- the heirachy structure dictates structs can only inherit diretly from System.ValueType

- structs
	- structs and interfacing
		- a struct can be implemented to one or more interfaces
		- struct types can then be cast to any interface type the interface dictates
	- the 'struct' keyword can be used to create user defined value types
	- a struct is typically used as a container for small sets of related variables
	- a struct example:
	
		public struct FullName
	{
		public string name;

		public FullName(string x1, string x2)
		{
			name = ($"{x1} {x2}");
		}
	}

- enums
	- all enums are derived from System.Enum which is derived from System.ValueType which is derived from System.Object
	-  enums are sets of named values that each correspond to an integer value
	- an enum example: 
	
		public enum TrafficLight
			{
				Red = 1;				Amber = 2;				Green = 3;		    }	- enums are useful for humans reading source code and understanding what is happening, while the compiler can simply and quickly pass around the integer values	- all rules that apply to structs also apply to enums