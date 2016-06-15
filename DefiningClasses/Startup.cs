namespace DefiningClasses
{
    using Classes;
    using System;


    public class Startup
    {
        static void Main()
        {
            var tests = new GsmTest();
            tests.DisplayGsmInformation();

            var call = new Call(new DateTime(2016, 06, 15, 22, 18, 25), "029374711", 120);
            Console.WriteLine(call.ToString());
            Console.WriteLine();

            var callTest = new GsmCallHistoryTest();
            callTest.TestCallHistory();
        }
    }
}
