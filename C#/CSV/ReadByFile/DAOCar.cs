using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadByFile
{
    internal class DAOCar:IDAO
    {
        static string[] info = File.ReadAllLines("../../../Values.txt");
        private int[] id=new int[info.Length];
        private string[] carName = new string[info.Length];
        private string[] carColor = new string[info.Length];
        private string[] carPlate = new string[info.Length];
        public List<Car> cars = new List<Car>();

        void IDAO.ReadFromInfo(string[] info)
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
        void IDAO.AddValues()
        {
            
            for (int i = 0; i < info.Length; i++)
            {
                cars.Add(new Car(id[i], carName[i], carColor[i], carPlate[i]));
                
            }
           
        }
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
