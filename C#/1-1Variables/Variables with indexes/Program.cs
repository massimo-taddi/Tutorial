/*
 what is a array?
 first of let's think of the array as a multiple containers in one variable.
 
 the basic syntax would be:

 value[] name = new int [length of the array];

 or you can also initialize the array with already some values in it

 int[] arrayExample= {1,2,3,4,5};

 with this we initialize an array that in his position 0 has the value 1

 int[] arrayExample1= new int [5];

 we are now initializing an array that has 5 empty spaces inside it

 to help you understand it better this is what an array theoretically looks like
 
 position (index) on the arrayExample:
                  0       1       2      3        4
              ________ _______  ______ _______  ______
array value   |   1  | |  2  |  | 3  | | 4  |   | 5  |
              ________ _______  ______ _______  ______
 
 */

int[] arrayExample = new int[5];
int[] arrayExample1 = { 1, 2, 3, 4, 5 };



/*
 * if we want to assing a specific value to a specific place in the array this is the synstax
 */
arrayExample[0] = 5;
Console.WriteLine(arrayExample[0]);

Console.WriteLine("write a value");
int value = int.Parse(Console.ReadLine());
arrayExample[1] = value;
Console.WriteLine(arrayExample[1]);

//IMPORTANT THINGS TO KNOW:
/*
 * 
 * you cant print an array without telling it wich position you want to print
 * if you want to try print an array without the position you are going to receive a  
 * "System.Int32[]" on the console which means that 
 * the console recive an array to print but he does not know the position you want to print
 
 * Console.WriteLine(arrayExample); <---WRONG!
 * Console.WriteLine(arrayExample[0]); <----Right!

 * Array can be initialize as whatever type of varible you like it can be an array of Objects, int, string ect.

 * another important thing to know is that his length MUST be defined when we initialize it 
 * unlike the list that we are gonna see soon.
 */




//Lists
/*
 * Lists are very much similar to the arrays 
 * the main difference to always keep in mind is that 
 * when you initialize a list you dont have to specify his lenght
 */
List<int> intList = new List<int>();

// to assign a value you must write listname.add();
intList.Add(50);
intList.Add(900);

// good to know
/*
 * With lists there exists some methods that can be useful:
 * .Count it count the elements in the list
 * .RemoveAt() to delete the value of a specific index
 * .Remove() to delete a specified value present in the list
 */

//Dictionary 
/*
 * Dictionary are not exacly a kind of variable that work with indexes but they work 
 * in a very similar method 
 */


//initialize a dictioanary 

Dictionary<string, string> dictionaryExample = new Dictionary<string, string>();

/*
 * the main particularity of dictionaries is that this kind of variable get 2 type of
 * variable when you initialize it in this case <string,string>
 * the first string is called "key" and the second string is called "value"
 * the "key" has a very similar role to the indexes in arrays and lists but in this case
 * it can be a variable as well:
 * you can initlialize a Dictionary with different kinds of variables 
 * not only string string
 */

//basic funtionalities

dictionaryExample["a"] = "hello";
//we are telling to add a container inside de dictionary
//with the key "a" and the value inside that container to be "hello"
Console.WriteLine(dictionaryExample["a"]);
//On the program the result will be the value attached to the key named "a"

//another example

Dictionary<string, int> nameAndAge = new Dictionary<string, int>();

nameAndAge.Add("hello", 70);
Console.WriteLine(nameAndAge["hello"]);

