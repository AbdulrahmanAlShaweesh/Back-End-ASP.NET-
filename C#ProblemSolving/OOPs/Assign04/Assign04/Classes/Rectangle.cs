using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign04.Classes
{
    internal class Rectangle
    {
        #region Properities
        private int width { get; set; }
        private int height { get; set; }    

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        #endregion

        #region Constructors
        public Rectangle()
        {
            height = 0; width = 0;
        }

        public Rectangle(int height , int width)
        {
            this.height = height; 
            this.width = width;
        }

        public Rectangle(int height)
        {
            this.height = height;
            this.width = height;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Height = {height} , Width = {width}";
        }
        #endregion
    }
}
