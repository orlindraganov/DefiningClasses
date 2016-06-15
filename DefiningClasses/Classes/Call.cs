namespace DefiningClasses.Classes
{
    using System;

    public class Call
    {
        public Call(DateTime dateAndTime, string phoneNumber, int duration)
        {
            this.Date = dateAndTime.ToShortDateString();
            this.Time = dateAndTime.ToLongTimeString();
            this.PhoneNumber = phoneNumber;
            this.DurationInSecs = duration;
        }

        public string Date
        {
            get; private set;
        }

        public string PhoneNumber
        {
            get; private set;
        }

        public int DurationInSecs
        {
            get; private set;
        }

        public string Time
        {
            get; private set;
        }

        public override string ToString()
        {
            var callInfo = $"{this.Date}\t{this.Time}\t{this.PhoneNumber}\t\t{this.DurationInSecs}";
            return callInfo;
        }
    }
}