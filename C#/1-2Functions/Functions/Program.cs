/*
 * Functions are a block of code that can have value as input and output and we can give a name to them
 * to recall them later in the program 
 * basic syntax of a function:
 * the value you expect when the code ends + the name of the function + (the initlialize values that you want the method to receive)
 */

string wordInput = Console.ReadLine();

int LengthOfTheWord(string word)
{
    int result = word.Length;
    return result;
}

//when you want to call back a the function you have to call it with the variable that has the value you want to check in this case wordInput
Console.WriteLine("The length of the word is " + LengthOfTheWord(wordInput));

//another example

int inPutValue=int.Parse(Console.ReadLine());   
string IsEven(int value)
{
    string result;
    if (value % 2 == 0)
    {
        result = "is even";
    }
    else
    {
        result = "is odd";
    }
    return result;
}
//basically when we call back a function that wants a input we make it so that the value inside the firm is equal to the value we want
//to check.
//the function want something to fill his request for a input as "value" and we are passing to the function the value we want
//which in  this case in "inPutValue" so evry time the function is using "value" inside of it is the same as if the function is using
//"inPutValue"
Console.WriteLine(IsEven(inPutValue));
