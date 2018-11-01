using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTaxi
{
    public enum status
    {
        NotAppointed,
        Appointed
    }

    public class Order
    {
        private string startPoint;
        private string endPoint;
        private int count;
        private status status;
        private string carNumber;

        public Order() { }

        public Order(string StartPoint, string EndPoint, int Count, status Status, string CarNumber)
        {
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
            this.Count = Count;
            this.Status = Status;
            this.CarNumber = CarNumber;
        }

        public string CarNumber
        {
            get
            {
                return carNumber;
            }
            set
            {
                carNumber = value;
            }
        }

        public string StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                startPoint = value;
            }
        }
        public string EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                endPoint = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (count > 8 && count < 0)
                {
                    throw new Exception("Count is not on interval");
                }
                else
                {
                    count = value;
                }
            }
        }
        public status Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
