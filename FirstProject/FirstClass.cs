using System;

namespace FirstProject
{
    // sealed keyword prevents other classes from inheriting from car
    sealed class Car
    {
        public string model;
        // class members: all fields and methods belonging to the class
        // public fields are accessible from other classes such as Program
        public string color = "Red";
        // maxSpeed inaccessible from outside of this class
        int maxSpeed = 200;
        public void fullThrotle()
        {
            Console.WriteLine("This car is going as fast as it can!");
        }

        // constructor (called when object is created)
        // it can optionally take args
        public Car(string modelName = "Mustang")
        {
            model = modelName;
        }
    
    }


    // properties
    class Person
    {
        public string species = "Human";
        private string name; // field
        public string Name // property
        {
            get { return name; } // get method
            set { name = value; } // set method
        }
        public int Age { get; set; } // short hand

        public virtual void greeting()
        {
            Console.WriteLine("Hi how are you");
        }
    }

    // class Doctor inherits all of Class persons fields/properties/methods
    class Doctor: Person
    {
        public string profession = "Doctor";
    }

    // Progammer class is derived from person. The species value is overriden
    // by the new value "Alien"
    class Programmer: Person
    {
        public new string species = "Alien";

        public override void greeting()
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/* 
 Access modifiers:
default is private
public: public fields are accessible from other classes such as Program
private: only accessible within the same class
protected: accessible within the same class or a class that is inherited from this class
internal: only accessible within its own assembly, but not from another assembly. 
 */