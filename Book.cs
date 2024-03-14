using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GA_Constructors_ManjulaRajan
{
    public class Book
    {
        private string title;
        private string author;

        // Default constructor(added notes below)
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
        }

        // Custom constructor with two parameters
        public Book(string title, string author) //used two parameter list
        {
            this.title = title;
            this.author = author;
        }

        // Overloaded constructor with one parameter
        public Book(string title) //Used only one parameter list
        {
            this.title = title;
            author = "Unknown";
        }

        // Properties for Title and Author
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        //what is Constructor and its role in class and purpose?

        //Answer:Constructors are methods that are automatically executed every time you create an object. The purpose of a constructor is to construct an object and assign values to the object's members. A constructor takes the same name as the class to which it belongs, and does not return any values.

        //Initialization: The constructor initializes the state of an object by assigning initial values to its attributes or performing any necessary setup tasks.

        //Default Constructor: If a class doesn't explicitly define any constructors, most programming languages provide a default constructor. This default constructor initializes the object's attributes to default values (e.g., null, 0, false, etc.).

        //Parameterized Constructors: Constructors can also be parameterized, meaning they can accept arguments.This allows for different ways of initializing objects depending on the provided parameters.

        //Multiple Constructors: Some languages support having multiple constructors with different parameter lists. This is known as constructor overloading. It allows for flexibility in object initialization.




        //Explain what a default constructor is and its behavior if not explicitly defined.

        //Answer: A default constructor is a constructor that is automatically provided by the compiler if no constructors are explicitly defined within a class. Its purpose is to initialize an object's attributes to default values.




        //*Below are the behavior of default constructors:

        //Automatic Generation: If a class does not define any constructors explicitly, the compiler generates a default constructor for that class.

        //No Parameters: Default constructors do not take any parameters.They initialize the object's attributes to default values, such as null, 0, or false, depending on the data type.

        //Implicit Invocation: Default constructors are implicitly invoked when an object of the class is created using the new keyword.

        //Default Values: The default values assigned by a default constructor depend on the data type of the attributes.For example:

        //Numeric types(int, float, double, etc.) are initialized to 0.
        //Boolean types are initialized to false.
        //Object references are initialized to null.
        //Arrays are initialized to null or an empty array, depending on the language.
        //Presence in Inheritance: In languages like Java, if a class does not explicitly define any constructors, and it is a subclass, the compiler will insert a call to the default constructor of its superclass.

        //Explicit Declaration Overrides: If any constructor is explicitly defined within a class (even if it's parameterless), the compiler will not generate a default constructor.

        //Customization: Although default constructors provide basic initialization, if a class requires specific initialization logic or initialization with parameters, custom constructors need to be defined explicitly.

        //In summary, a default constructor is automatically provided by the compiler if a class does not define any constructors explicitly.It initializes the object's attributes to default values, ensuring that objects are properly initialized when they are created.






        //Explain the purpose of creating custom constructors?

        //Answer; A constructor eliminates calling the normal method implicitly.  Automatic initialization of objects at the time of their declaration. Multiple ways to initialize objects according to the number of arguments passes while declaration.






        //How overloading constructors provides flexibility in object initialization.

        // Answer:By defining multiple constructors with different parameter lists, developers can create objects with different initial states without having to create separate classes.







        //Explain why initializing fields in constructors is a good practice?

        //Answer; 1. Ensures Object Integrity 2.Ensures Object Integrity: 3.Encapsulation 4.Flexibility and Maintenance 5.Default Values 6.Constructor Overloading 7. Facilitates Dependency Injection






    } // class

} // namespace
