//OBJECTS
/*
 * what is a object? and why is so important in C#?:
 * a object is a complex variable, that stands at the center of the OOP Object Oriented Programming, is basically a instance
 * of a class that allows you to implement evry focal point of the OOP which are:
 * -Encapsulation, it allows you to group the data you implement and methods under a single class, and hide the way you implement them,
 * and allows the use only to see the result of such actions;
 * -Polymorphism, allows classes to be treated as a istance of another class, allowing to alter the result of the methods
 * inside the classes by which class was instantiated;
 * -Abstraction, allows the user to interect with the single class without allowing him to know how methods works inside the class, and
 * which data are used inside the class;
 * -Inheritance, it allows you to create a relation between a "father" class and a "son" class, which allows the "son" class
 * to inherit some if not every attribute of the "father" class;
 * -Reusage of the code, since we are creating object with a class we can reuse it inside our whole project,
 * allowing use to just recall the object in other parts of the program insted of re writing evrytime the code.
 */

//how to create a class
/*
 * explore solutions-->right click the name of the solution in this case Objects -->"add" -->"New Element"--->"Class"
 */

//we are specifying that we are using the nameSpace Objects
using Objects;
Console.WriteLine("please write a name");
string name = Console.ReadLine();
Console.WriteLine("please write your lastname");
string lastName=Console.ReadLine();
Person p =new Person(name,lastName);

Console.WriteLine(p.Print(name,lastName));