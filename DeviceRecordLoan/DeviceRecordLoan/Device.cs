using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceRecordLoan
{
    internal class Device
    {
        public string ModelName { get; private set; }
        public string ModelID { get; private set; }
        public int YearBought { get; private set; }
        public decimal Cost { get; private set; }
        public int Quantity { get; private set; }
        public List<int> Status { get; private set; }

        public Device(string modelName, string modelID, int yearBought, decimal cost, int quantity)
        {
            ModelName = modelName;
            ModelID = modelID;
            YearBought = yearBought;
            Cost = cost;
            Quantity = quantity;
            Status = new List<int>(quantity);
        }
    }
}
