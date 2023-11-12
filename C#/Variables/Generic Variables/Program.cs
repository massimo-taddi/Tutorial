/*
 * let's think of variables as "containers" the synstax for the most "basic" variables is  
 * "type name=value"
 * for example
 */
//int stands for integer and is use to assign a numeric value without comma.
// 5 is a int type of value.
// 5.1 is a double type of value

int value0 = 5;

//to give a variable a value with a comma we use double
double value1 = 6.2;

//if we want to save text or lines of text we save it as string
string phrase = "hello world";

//bolean is a type of value that can only be true or false we will learn out to use it
bool response = true;

/*
 * those are not every varible that can be used,
 * there exist many, many more "basic" variables.
 * those are just the ones that we are gonna use
 */

/*
 * Console commands:
 * for this tutorial we are going to use a couple of console command 
 * Console.WriteLine() allows you to write anything you want on the console while running the program
 * Console.ReadLine() allows you to give a input to the console while running.
 */


Console.WriteLine("hi");
// you can print on console the value of the variables just buy putting their variable name insinde the () of Console.WriteLine()
Console.WriteLine((value0) + phrase);

//Console.ReadLine() allows you to recive a input from the console

Console.ReadLine();

// you can use read line to give value to a variable for example

string word = Console.ReadLine();
Console.WriteLine("this is the word you wrote " + word);


/* 
* by default Console.ReadLine() will expect you to write a string but if you want to 
* assign a value of different type you must parse it.
* 
* you can parse it by simply putting:
* 
* variabletype.Parse(valuetocheck) a easy example would be
* 
* int answer=int.Parse(Console.ReadLine());
* 
* in the example we initialize a int type variable and we make it equals
* to the input that we receive in the console converted as int.
* if the console find strings while he tries to parse it the program will break.
* 
*/



//BASIC OPERATIONS
/*
 * the most basic operation that we can have are
 * 
 * Addiction wich uses + sign
 * Subtraction wich uses - sign
 * Multiplication wich uses * sign
 * Division which uses + sign
 * 
 * Examples
 * 
 */
//example for int value.

//Addiction
/* 
int valueToSum1 = 1;
int valueToSum2 = 2;

int result = valueToSum1 + valueToSum2;
Console.WriteLine("Result of the Addition"+result);
*/
//Subtraction 
/* 
int higherValue = 5;
int valueToSubtract = 3;
int result1 = higherValue - valueToSubtract;
Console.WriteLine("Result of the Subtraction "+result1);
*/
//Multiplication 
/* 
int value2 = 2;
int value3 = 2;
int result2 = value2 * value3;
Console.WriteLine("Result of the Multiplication " + result2);
*/
//Division 
/* 
int Value4 = 6;
int value5 = 3;
int result3 = Value4 / value5;
Console.WriteLine("Result of the Division " + result3);
*/

//example for string value
/*
 * beign a string dosent allow you to do most of the operations but you can concatenate more strings
 */

string firstName = "Mike";
string lastName = "Tyson";
Console.WriteLine(firstName + " " + lastName);

//good to know 
/*
 * be careful when you initialize something, you can save values as string for example
 * 1 can be saved as a string but it will also be treated as such 
 * if you initialize a value of type string and you insert a numeric value 
 * the program will treat that string as text and not as a int value, and for that you cannot
 * use operations as + - * / because the console treat it as a string and not int
 */