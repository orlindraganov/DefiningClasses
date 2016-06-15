namespace DefiningClasses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Display
    {
        private int? size;
        private int? numberOfColors;

        public Display(int size)
        {
            this.size = size;
        }

        public Display(int size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
    }
}
