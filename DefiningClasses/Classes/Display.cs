using System.Text;

namespace DefiningClasses.Classes
{
    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display(double size)
        {
            this.size = size;
        }

        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            if (this.Size == null)
            {
                output.Append("Unknown size; ");
            }
            else
            {
                output.Append($"Size: {this.Size}");
            }

            if (this.NumberOfColors == null)
            {
                output.Append("Unknown number of colors");
            }
            else
            {
                output.Append($"Number of colors: {this.NumberOfColors}");
            }

            return output.ToString();
        }
    }
}
