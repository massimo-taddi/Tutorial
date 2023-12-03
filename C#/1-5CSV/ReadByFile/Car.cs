using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadByFile
{
    internal class Car
    {
       

        public int CarId {  get; set; }
        public string CarName {  get; set; }
        public string CarColor { get; set; }
        public string CarPlate {  get; set; }

        public Car(int carId, string carName, string carColor, string carPlate)
        {
            CarId = carId;
            CarName = carName;
            CarColor = carColor;
            CarPlate = carPlate;
        }

    }
}
