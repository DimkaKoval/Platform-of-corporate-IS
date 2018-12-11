using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTaxi
{
    public class Taxist
    {
        private string carModel;
        private string number;
        private bool busy;

        public Taxist() { }

        public Taxist(string CarModel, string Number, bool Busy)
        {
            this.CarModel = CarModel;
            this.Number = Number;
            this.Busy = Busy;
        }

        public string CarModel
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public bool Busy
        {
            get
            {
                return busy;
            }
            set
            {
                busy = value;
            }
        }
    }
}
