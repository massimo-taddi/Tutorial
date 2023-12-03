using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadByFile
{
    internal class DAOCar:IDAO
    {
        // we initialize an array with the value equals to the row inside the CSV File
        static string[] info = File.ReadAllLines("../../../Values.txt");
        //we create one array foreach value we find in the CSV
        //so that we can split the value inside the rows of the CSV file and
        //put evry single value inside a specified array.
        private int[] id=new int[info.Length];
        private string[] carName = new string[info.Length];
        private string[] carColor = new string[info.Length];
        private string[] carPlate = new string[info.Length];
        public List<Car> cars = new List<Car>();

        //it implement a method void so without anything in return that when called in the program
        //it reads the values inside the array info which are the values of the CSV File and split them
        //by a specified symbol in this case ';'.
        //More specifically it first of all Read the value it assigns it the index and then it repeat 
        //this method evrytime it finds ';'
        //example
        //first value is the index so first of all it reads the value 1 it assign the index 0 and if it finds the ';'
        //simbol it repeat but this time when he read it will assign the value 1, and this happens every time it finds
        //';' if he dosent find ';' it will stop split the values and the program will continue.
        void IDAO.ReadFromArray(string[] info)
        {
            for (int i=0;i<carName.Length;i++)
            {
                string[] splittedValues = info[i].Split(';');

                id[i] = int.Parse(splittedValues[0]);
                carName[i] = splittedValues[1];
                carColor[i] = splittedValues[2];
                carPlate[i] = splittedValues[3];
                
            }
        }
        //this is a method that adds to a List of objects Car a object car,
        //why did i do it?
        //i wanted to use all the array that we fill with ReadFromArray and use them all to creata object
        //so that we had a single object for all the array position 0 1 2 3, and that this single object that we fill
        //with the values of the array could have been add to the list of object so that we now have 
        //a list of objects fill with objects that have the values of the CSV file
        void IDAO.AddValues()
        {
            
            for (int i = 0; i < info.Length; i++)
            {
                cars.Add(new Car(id[i], carName[i], carColor[i], carPlate[i]));
                
            }
           
        }
        //this is a method only ment to print the values of the single car inside the the list
        //basically foreach Object inside the list it does a line of code in this case
        //it adds to a string :
        /*
         * the id that he is reading +
         * the carn name +
         * the car color + 
         * the car plate
         */
        //and it does it for each object that he finds so the first read will be for the first object 
        //the second for the second object etc..
        //when we recall this method in the program it will return a string with all the values that we made 
        //it save inside the "result" string.
        string IDAO.PrintObject()
        {
            string result = "";
            foreach (Car car in cars) 
            {
                result += $"id: {car.CarId}\n" +
                        $"CarName: {car.CarName}\n" +
                        $"CarColor: {car.CarColor}\n" +
                        $"CarPlate:{car.CarPlate} \n";
            }
            return result;
        }

        
    }
}
