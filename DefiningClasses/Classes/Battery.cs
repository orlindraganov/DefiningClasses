namespace DefiningClasses.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.model = model;
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
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
    }
}
