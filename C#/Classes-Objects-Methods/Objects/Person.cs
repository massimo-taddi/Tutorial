using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//the namespace stands for the name of the project that we are gonna use in this caseis "Objects"
namespace Objects
{
    //interal limits the visibility of this class to allow it to be used only when the associated executable file is run
    internal class Person
    {

        
        private string Name { get; set; }
        private string LastName {  get; set; }


        //this is called builder allows you to give a value to the incapsulated attribute of the class in this case
        //when we will call the class Person in the Program we will give it the 2 input he requires which are name,lastname
        //and the builder will make them equal to Name and LastName so that when we call the Object Person in the program
        //to use his incapsulated values.
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        //--What are the benefit of this method?
        //it add a level of protection because when we call the Object we recall the incapsulated attribute insted of the value we receive
        //as input. it allows us to add a layer of protection to the entire class, and allows us to hide sensitive data.
        //Another Benefit is that keeps the Program very clean, we only need to give the class his input and then 
        //we can call back his methods or just his variables without writing the methods on the program


        public string Print(string name,string lastName)
        {
            string result = "";
            result = "the name you input is " + name + "\nthe last name you input is " + lastName;
            
            return result;
        }
        //what are the accessibility modifiers

        /*
         * the accessibility modfiers allows you to have full control over methods, attribute or class that you implement,
         * allowing you to decide what has access to what inside the project regarding the specified attribute method
         * or class you are implementing.
         * to understand them we must first understand what is an assembly.
         * Assembly: in .Net is a file or a dll created by compiling one or more .cs files.
         * -Public, Evrybody can Access it inside the program.
         * -Protected, accessible by the same class, derived classes and derived classes with different assembly.
         * -Internal, it is not accessible by different assembly.
         * -Protected internal, it cant be accesed by different class with different assembly.
         * -Private, it can only be accesed by the same class.
         * -Private protected, only accessible by the same class and derivied classes.
         */



    }
}
