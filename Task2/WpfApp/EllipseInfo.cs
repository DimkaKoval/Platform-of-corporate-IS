/// <summary>
/// Namespace WpfApp
/// </summary>
namespace WpfApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Shapes;

    /// <summary>
    /// Info Class
    /// </summary>
    public class EllipseInfo
    {
        /// <summary>
        /// Fields contain information about ellipse
        /// </summary>
        private Point topLeft;
        private Point botRight;
        private string name;
        private Ellipse shape;

        /// <summary>
        /// creating new ellipse
        /// </summary>
        public EllipseInfo()
        {
            shape = new Ellipse();
        }

        /// <summary>
        /// Property for TopLeft point
        /// </summary>
        public Point TopLeft
        {
            get
            {
                return topLeft;
            }
            set
            {
                topLeft = value;
            }
        }

        /// <summary>
        /// Property for TopRight point
        /// </summary>
        public Point BotRight
        {
            get
            {
                return botRight;
            }
            set
            {
                botRight = value;
            }
        }

        /// <summary>
        /// Property for name ellipse
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Property for shape ellipse
        /// </summary>
        public Ellipse Shape
        {
            get
            {
                return shape;
            }
            set
            {
                shape = value;
            }
        }
    }
}
