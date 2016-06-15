using System;
using System.Linq;

namespace DefiningClasses.Classes
{
    public class GsmCallHistoryTest
    {
        private Gsm myGsm = new Gsm("3310", "Nokia");
        private decimal PricePerMin = 1.30M;

        public void TestCallHistory()
        {
            myGsm.AddCall(new Call(new DateTime(2016, 6, 15, 21, 30, 15), "010555", 300));
            myGsm.AddCall(new Call(new DateTime(2016, 6, 15, 21, 45, 32), "166", 205));
            myGsm.AddCall(new Call(new DateTime(2016, 6, 15, 22, 0, 0), "180", 50));
            myGsm.AddCall(new Call(new DateTime(2016, 6, 15, 22, 5, 15), "Hidden Number", 25));
            myGsm.AddCall(new Call(new DateTime(2016, 6, 15, 22, 10, 15), "0888717250", 14));

            var totalPrice = myGsm.CalculatePrice(PricePerMin);

            Console.WriteLine(myGsm.CallHistoryInfo());
            Console.WriteLine($"Total price: {totalPrice:F2} BGN");

            Call longestCall = myGsm.CallHistory.OrderByDescending(x => x.DurationInSecs).First();

            myGsm.DeleteCall(longestCall);

            totalPrice = myGsm.CalculatePrice(PricePerMin);

            Console.WriteLine($"Total price excl longest call: {totalPrice:F2} BGN");

            myGsm.ClearHistory();

            Console.WriteLine(myGsm.CallHistoryInfo());
        }
    }
}
