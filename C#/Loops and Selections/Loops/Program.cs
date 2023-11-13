/*
 * Loops are use to do a Number of times a block of code 
 * there exist 4 of them:
 * -for 
 * -foreach
 * -while 
 * -do while
 */

//FOR
/*
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("hello" + i);
    }

    this is a exemple of a loop for, you must:
    initializeavariable;condition;whathappenswhenthecodefinishes;
    
    in this case we initialize a variable with value 0; the condition is until i is < 5
    do the block of code between {}; evrytime you do the block of code increase i by 1

 */

//FOREACH
/*

int[] intArray = {1,2,3,4,5};
foreach (int i in intArray)
{
    Console.WriteLine("this is the int value inside the array " + i);
}

foreach is a type of loop that does the block of code evrytime the condition inside the ()
is find true in this case evrytime the loop finds a value int inside the aray 
it does the block of code

 */

//WHILE
/*

bool enter = true;
string answer = "";
while (enter == true)
{
    Console.WriteLine("you are inside the loop");
    Console.WriteLine("you you want to exit the loop?");
    answer = Console.ReadLine();
    if (answer.ToLower() == "yes")
    {
        enter = false;
    }
    else
    {
        continue;
    }
}


While and do while are a type of loop that are used in case we need to do a loop that must
be repeated a N number of times but we dont know how many times.
in this case we execute the block of code evrytime the variable enter is equal to true
if the bool variable enter is false it breakes on the next iteration of the loop
 */

//DO WHILE
/*

bool enter = true;
do 
{
    Console.WriteLine("you are inside the loop");
    string answer = "";
    Console.WriteLine("do you want to exit the loop?");
    answer = Console.ReadLine(); 
    if (answer.ToLower() == "yes")
    {
        enter = false;
    }
} while (enter==true);


Do While is very similar to the While loop but the main difference is that
before it tries the condition to start the loop it first does the block of code 
 */

//Main difference
/* 
 * for the loop type for we know we have to execute the block of code a specified number
 * of times,
 * whereas the loop type while and do while is used to execute a block of code N numbers
 * of times
*/

//Good to know
/*
 * inside the loops and switch you can you the command "break;" to exit the loop on that
 * specific point and "continue;" to restart the loop  when it reaches it;
 * you can use the same commands on the switch.
 */
