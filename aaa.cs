namespace hello


using System;

namespace OOPExample
{
    // Abstract class (Abstraction)
    abstract class Animal
    {
        // Encapsulation: private field with public property
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Abstract method (must be overridden)
       
