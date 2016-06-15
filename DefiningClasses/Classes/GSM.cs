namespace DefiningClasses
{
    using Classes;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Gsm
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public Gsm(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public Gsm(string model, string manufacturer, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public Gsm(string model, string manufacturer, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
        }

        public Gsm(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Battery = battery;
            this.Display = display;
        }

        public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException("No model added");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException("No manufacturer added");
                }
            }
        }

        public decimal? Price
        {
            get
            {
                return this.Price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public string CallHistoryInfo()
        {
            var output = new StringBuilder();

            if (this.CallHistory.Count == 0)
            {
                return "No history";
            }

            output.Append("Date\t\tTime\t\tDialed number\tDuration secs\n\r");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                output.Append(this.callHistory[i].ToString());
                output.Append("\n\r");
            }

            return output.ToString();
        }

        public decimal CalculatePrice(decimal pricePerMin)
        {
            var totalSeconds = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].DurationInSecs < 60)
                {
                    totalSeconds += 60;
                }
                else
                {
                    totalSeconds += this.callHistory[i].DurationInSecs;
                }
            }
            decimal totalPrice = totalSeconds * (pricePerMin / 60);

            return totalPrice;
        }

        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void DeleteCall(Call currentCall)
        {
            this.callHistory.Remove(currentCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            string toAdd = string.Format($"Model:\t\t{this.model}");

            output.Append(toAdd)
                  .Append("\n\r");

            toAdd = string.Format($"Manufacturer:\t{this.manufacturer}");

            output.Append(toAdd)
                  .Append("\n\r");

            if (this.price != null)
            {
                toAdd = string.Format($"Price:\t\t{this.price:F2}");
            }
            else
            {
                toAdd = "Price:\t\tN/A";
            }

            output.Append(toAdd)
                  .Append("\n\r");

            if (!string.IsNullOrEmpty(this.owner))
            {
                toAdd = string.Format($"Owner:\t\t{this.owner}");
            }
            else
            {
                toAdd = "Owner:\t\tN/A";
            }

            output.Append(toAdd)
                  .Append("\n\r");

            if (this.battery != null)
            {
                toAdd = string.Format($"Battery:\t{this.battery}");
            }
            else
            {
                toAdd = "Battery:\tN/A";
            }

            output.Append(toAdd)
                  .Append("\n\r");

            if (this.display != null)
            {
                toAdd = string.Format($"Display:\t{this.display}");
            }
            else
            {
                toAdd = "Display:\tN/A";
            }

            output.Append(toAdd)
                  .Append("\n\r");

            return output.ToString();
        }

        public static readonly Gsm Iphone4S = new Gsm("iPhone 4S", "Apple", 180, "The anonymous author of the code", new Battery("iPhone battery", BatteryType.LiIon), new Display(3.5, 16000000));

    }
}
