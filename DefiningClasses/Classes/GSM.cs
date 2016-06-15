namespace DefiningClasses
{
    using DefiningClasses.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public GSM(string model, string manufacturer, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = battery;
            this.display = display;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        
    }
}
