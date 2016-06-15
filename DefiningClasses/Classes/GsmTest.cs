namespace DefiningClasses.Classes
{
    public class GsmTest
    {
        private Gsm[] phones =
            {
            new Gsm(3310.ToString(), "Nokia", 19.90M, "Everybody At Least Once", new Battery("Nokia Battery", BatteryType.NiMh), new Display(0.5, 2)),
            new Gsm("Unknown", "Sorry Ericsson", 15.90M),
            new Gsm("Pesho", "Gosho", "Pesho Goshov")
        };
        public void DisplayGsmInformation()
        {
            for (int i = 0; i < phones.Length; i++)
            {
                phones[i].DisplayInfo();
            }

            Gsm.Iphone4S.DisplayInfo();
        }
    }
}
