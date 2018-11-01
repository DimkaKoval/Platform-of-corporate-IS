//-----------------------------------------------------------------------
// <copyright file="Taxist.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    /// <summary>
    /// Class with information about driver
    /// </summary>
    public class Taxist
    {
        /// <summary>
        /// Value contain car model
        /// </summary>
        private string carmodel;

        /// <summary>
        /// Value contain car number
        /// </summary>
        private string number;

        /// <summary>
        /// Value contain driver status
        /// </summary>
        private bool busy;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Taxist"/> class.
        /// Constructor without parameters
        /// </summary>
        public Taxist()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Taxist"/> class.
        /// Constructor with parameters
        /// </summary>
        /// <param name="carmodel">Car model</param>
        /// <param name="number">Car number</param>
        /// <param name="busy">Driver status</param>
        public Taxist(string carmodel, string number, bool busy)
        {
            this.CarModel = carmodel;
            this.Number = number;
            this.Busy = busy;
        }

        /// <summary>
        /// Gets or sets CarModel property.
        /// </summary>
        public string CarModel
        {
            get { return this.carmodel; }
            set { this.carmodel = value; }
        }

        /// <summary>
        /// Gets or sets car Number property.
        /// </summary>
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        /// <summary>
        /// Gets or sets status Busy property.
        /// </summary>
        public bool Busy
        {
            get { return this.busy; }
            set { this.busy = value; }
        }
    }
}
