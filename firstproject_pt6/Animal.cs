using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject_pt6 {
    class Animal {
        //      PROTECTING DATA
        public string name;         // Not protected. The user can just go in and change. 
        private string specie;      // Protected. The value can only be accesed by a method inside the fild or by a subclass.
        protected string sound;     // Protected. The value can only be accesed by classes or subclasses.

        public const string SHELTER = "Nemi's home for Animals";    // It's a constant so it cannot be changed anywhere except for here. Constant is constant, duh. 


        //      READONLY
        public readonly int idNum;  
        public void MakeSound() {   // This part is the method. 
            Console.WriteLine("{0} is a {1} and says {2}", name, specie, sound);
        }
        

        //      CONSTRUCTORS
        public Animal()     // Defult constructor
            :this("No Name", "No Specie", "No Sound") { }
 
        public Animal(string name)      // What
            :this(name, "No specie", "No Sound") { }
        
        public Animal(string name, string specie, string sound) {      // Constructor that receves parameters
            SetName(name);
            Sound=sound;

            NumOfAnimals=1;

            Random rnd = new Random();
            idNum=rnd.Next(1, 2147483640);
        }

        public void SetName(string name) {
            if(!name.Any(char.IsDigit)) {   // Checks every character for a digit.
                this.name=name; 
            }
            else {
                this.name="No Name";
                Console.WriteLine("Name can't contain numbers.");
            }
        }


        //      GETTERS & SETTERS
        public string GetName() {
            return name;
        }

        public string Sound {   // This is a property
            get { return sound; }
            set {
                if(value.Length > 10) {
                    sound="No Sound";
                    Console.WriteLine("Sound is too long.");
                }
                sound=value;
            }
        }

        public string Owner { get; set; } = "No Owner";     // A shortcut.

        public static int numOfAnimals = 0;
        
            public static int NumOfAnimals {
            get { return numOfAnimals; }
            set { numOfAnimals+=value; }
        }
    }
}
