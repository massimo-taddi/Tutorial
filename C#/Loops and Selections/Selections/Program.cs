/*
 The main type of Selections are 3
 if,ternary and switch
 */

//if 
/*
int value = 5;
int value0 = 4;
if (value > value0)
{

    Console.WriteLine(value + " is hihger then " + value0);
}
basically if the condition is true return the block of code if not you can add
a:

else
{

}

section with another block of code when the condition inside the if() is not true
it execute the block of code inside the else{}
 */

//good to know
/*
 if(intvalue % 2 ==0)
 {

 }
 if(intvalue % 2 ==1)
 {

 }

 % means that if the int value divided by the value after % return 0 it means the value is
 even and if so do the specific line of code.
 if you make it % 2 ==1 means that if the value you divide by 2 return a value 
 of at least 1 it means is odd and do the specific line of code if is odd.
 
*/

//ternary
/*
int value1 = 10;
int value2 = 11;

string result=(value1>value2)? ("value 1 is higher") : ("value 2 is higher");
Console.WriteLine(result);

string result=(condition)? (what happens if is true) : (what happens if it is false);
 */

//switch
/*
Console.WriteLine("write a number between 1 and 5");
int value = int.Parse(Console.ReadLine());

switch (value)
{
    case 1:
        Console.WriteLine("you wrote " + value);
        break;
    case 2:
        Console.WriteLine("you wrote " + value);
        break;
    case 3:
        Console.WriteLine("you wrote " + value);
        break;
    case 4:
        Console.WriteLine("you wrote " + value);
        break;
    case 5:
        Console.WriteLine("you wrote " + value);
        break;
}
switch is use in the case we need different outcome based on a response or a variable

 */




