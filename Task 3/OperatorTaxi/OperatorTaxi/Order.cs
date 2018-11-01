<<<<<<< HEAD
﻿//-----------------------------------------------------------------------
// <copyright file="Order.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System;

    /// <summary>
    /// Enum value contain status request
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Driver isn't appointed
        /// </summary>
        NotAppointed,

        /// <summary>
        /// Driver is appointed
        /// </summary>
        Appointed
    }

    /// <summary>
    /// Class Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Value contains place of departure
        /// </summary>
        private string startPoint;

        /// <summary>
        /// Value contains place of arrival
        /// </summary>
        private string endPoint;

        /// <summary>
        /// Value contains trip price
        /// </summary>
        private int count;

        /// <summary>
        /// Value contains status request
        /// </summary>
        private Status status;

        /// <summary>
        /// Value contains car number
        /// </summary>
        private string carNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Order"/> class.
        /// Constructor without parameters
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Order"/> class.
        /// Constructor with parameters
        /// </summary>
        /// <param name="startpoint">Place of departure</param>
        /// <param name="endpoint">Place of arrival</param>
        /// <param name="count">Trip price</param>
        /// <param name="status">Status request</param>
        /// <param name="carnumber">Car number</param>
        public Order(string startpoint, string endpoint, int count, Status status, string carnumber)
        {
            this.StartPoint = startpoint;
            this.EndPoint = endpoint;
            this.Count = count;
            this.Status = status;
            this.CarNumber = carnumber;
        }

        /// <summary>
        /// Gets or sets CarNumber property.
        /// </summary>
        public string CarNumber
        {
            get { return this.carNumber; }
            set { this.carNumber = value; }
        }

        /// <summary>
        /// Gets or sets StartPoint property.
        /// </summary>
        public string StartPoint
        {
            get { return this.startPoint; }
            set { this.startPoint = value; }
        }

        /// <summary>
        /// Gets or sets EndPoint property.
        /// </summary>
        public string EndPoint
        {
            get { return this.endPoint; }
            set { this.endPoint = value; }
        }

        /// <summary>
        /// Gets or sets Count property.
        /// </summary>
        public int Count
        {
            get { return this.count; }

            set
            {
                if (this.count > 8 && this.count < 0)
=======
﻿using System;
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
>>>>>>> 69475dd58d1dd7cfbd41bacb19a43a91ce78a4ba
                {
                    throw new Exception("Count is not on interval");
                }
                else
                {
<<<<<<< HEAD
                    this.count = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets Status property.
        /// </summary>
        public Status Status
        {
            get { return this.status; }
            set { this.status = value; }
=======
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
>>>>>>> 69475dd58d1dd7cfbd41bacb19a43a91ce78a4ba
        }
    }
}
