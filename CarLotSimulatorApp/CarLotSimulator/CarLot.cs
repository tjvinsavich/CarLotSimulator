using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            CarList = new List<Car>();
        }

        public List<Car> CarList { get; set; }

    }
}
