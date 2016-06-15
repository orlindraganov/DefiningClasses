namespace DefiningClasses.Classes
{
    using System;
    using System.Text;
    public class Battery
    {
        private string model;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, float hoursIdle, float hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery(string model, BatteryType batteryType)
        {
            this.model = model;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public float? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours Idle cannot be negative");
                }
            }
        }

        public float? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Hours talk cannot be negative");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.Append($"Type - {this.BatteryType}; ");

            if (this.HoursTalk == null)
            {
                output.Append("Hours talked - No info; ");
            }
            else
            {
                output.Append($"Hours talked - {this.HoursTalk}; ");
            }

            if (this.HoursIdle == null)
            {
                output.Append("Hours idle - No info; ");
            }
            else
            {
                output.Append($"Hours idle - {this.hoursIdle}; ");
            }

            return output.ToString();
        }
    }
}