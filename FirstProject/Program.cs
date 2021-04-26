using System; // this is a namespace
using System.Linq; // contains useful array methods

namespace FirstProject
{
    class Program
    {
        // Main is a special method. All code in Main is executed 
        static void Main(string[] args)
        {
            /* same as System.Console.WriteLine("...")
             -> you can ommit "using System" */
            Console.WriteLine("Hello World!");
            /* Console.WriteLine() -> prints on new line
             Console.Write() -> prints on the same line */

            string firstName = "Chiraag"; // string data type
            string lastName = "Anand";
            char letter = 'c'; // use single quotes for char
            bool bull = false;

            Console.WriteLine("My name is " + firstName + " " + lastName);
            Console.WriteLine("Some char: "+letter+" Some bool: "+bull);

            // number data types
            int x = 10;
            long y = 1020232420234342343L; // value ends with L
            float w = 20.22F; // value ends with F
            double z = 3.2343344343434D; // value ends with D
            Console.WriteLine("Bunch of numbers "+" "+x+" "+y+" "+w+" "+z);

            // scientific notation
            float f1 = 35e3F; // use e to represent powers of 10
            Console.WriteLine("Scientific notation: " + f1);

            // casting
            // implicit casting for converting smaller data type to larger 
            // example: char -> int -> long -> float -> double
            int myInt = 9;
            double myDouble = myInt; // implicit casting
            Console.WriteLine(myInt + " " + myDouble);

            // For converting larger data types to smaller use manual casting
            myDouble = 9.78;
            myInt = (int)myDouble;
            Console.WriteLine(myInt + " " + myDouble);

            // type conversion using built in methods
            int anotherInt = 10;
            double anotherDouble = 2.22;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(anotherInt));
            Console.WriteLine(Convert.ToDouble(anotherInt));
            Console.WriteLine(Convert.ToInt32(anotherDouble));
            Console.WriteLine(Convert.ToString(myBool));


            // reading command line input
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine(); // readLine returns a string
            Console.WriteLine("Welcome " + username);
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age + " is pretty young!");


            // inbuilt Math
            Console.WriteLine(Math.Max(5, 10)); // returns the larger of 2 ints
            // other common methods: .Min .Abs .Sqrt .Round


            // Strings
            // string methods .Length() .ToUpper() .ToLower() .Concat(a, b)

            // String interpolation
            string text1 = "Chiraag";
            string text2 = "Anand";
            string fullName = $"My full name is {text1} {text2}";
            Console.WriteLine(fullName);
            Console.WriteLine(fullName[0]); // accessing strings
            Console.WriteLine(fullName.IndexOf("g")); // finds index
            // Substring returns a "sub" string starting from specified index
            Console.WriteLine(fullName.Substring(4));

            // \ is for escape \n is new line \t is tab \b is backspace

            // if, if else, else and switch are the exact same as javascript
            // ternary is exact same as javascript

            // while and do while same as C

            // for loop same as javascript

            // foreach loop and arrays
            string[] cars = {"BMW", "Mazda", "Audi"}; // array of strings
            Array.Sort(cars); // sort in ascending order
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // linq methods
            // declaring an array without assigning values
            int[] myNumbers = new int[4];
            myNumbers[0] = 1; myNumbers[1] = 5;
            myNumbers[2] = 9; myNumbers[3] = 8;
            Console.WriteLine(myNumbers.Max()); // returns max value from arr
            // other methods include .Min and .Sum

            MyMethod(); // falls back to default value for name arg
            MyMethod("Bob"); // order of args matters
            MyMethod(name: "Tom"); // order of args does not matter

            // calling custom class
            Car forester = new Car("Forester");
            forester.color = "white";
            Console.WriteLine(forester.color);
            Console.WriteLine(forester.model);
            forester.fullThrotle();
            Person tom = new Person();
            tom.Name = "Tom";
            Console.WriteLine(tom.Name);
            Doctor bob = new Doctor();
            bob.Name = "Bob";
            Console.WriteLine(bob.Name);

        }

        // methods
        // static means that the method belongs to the program
        // and not the object of the program class
        // the method is called like this Program.MyMethod()
        // do not need to create object instance of Program class
        static void MyMethod(string name = "defaultname")
        {
            Console.WriteLine(name + ", MyMethod says hi!");
        }


        // method overloading
        // multiple methods can have same name as long as return type is diff
        static int PlusMethod(int x, int y)
        {
            return x + y; 
        }

        static double PlustMethod(double x, double y)
        {
            return x + y;
        }
    }
}


/* Data types:
    int 4 bytes
    long 8 bytes
    float 4 bytes (6-7 decimal digits)
    double 8 bytes (15 decimal digits)
    char 2 bytes
    string 2 bytes per character
    bool 1 bit

  use const keyword to declare constants


All standard operators are available

math: + - / * % ++ --
asignment: = += -= *= /= %= != |= ^=  >>= <<=
comparison: == != < > >= <=
logical: && || !
*/
