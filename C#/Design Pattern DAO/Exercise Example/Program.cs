using Exercise_Example;
using System.Reflection.Metadata.Ecma335;
//we initialize a variable of type IDAO
IDAO dao = new DAONumbers();


int[] array1 = new int[5];
int[] array2 = new int[5];
bool enter = true;
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine("input a number for the first array");
    array1[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine("input a number for the second array");
    array2[i] = int.Parse(Console.ReadLine());
}
Numbers n = new Numbers(array1, array2);
while (enter)
{
    Console.WriteLine("Choose 1 to read a random number from the first array \n" +
                      "Choose 2 to read a random number from the second array \n" +
                      "Choose 3 to print the sum of both arrays \n" +
                      "Choose 4 to print the first array \n" +
                      "Choose 5 to print the second array");
    string answer = "";
    answer=Console.ReadLine();
    switch (answer.ToLower())
    {

        case "1":
            Console.Clear();
            Console.WriteLine("the random number from the first array is " + dao.ReadRandomValueFromArray1(n.Array1) +"\n\n");
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("the random number from the second array is " + dao.ReadRandomValueFromArray2(n.Array2) + "\n\n");
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("the sum is " + dao.SumBothArray(n.Array1, n.Array2) + "\n\n");
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("the first array is " + dao.PrintFirstArray(n.Array1) + "\n\n");
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("the second array is " + dao.PrintSecondArray(n.Array2) + "\n\n");
            break;
        


    }
    Console.WriteLine("do you want to continue? Yes/No");
    answer = Console.ReadLine();
    if (answer.ToLower() == "yes")
    {
        Console.Clear();
        continue;
    }
    else
    {
        enter = false;
    }


}


