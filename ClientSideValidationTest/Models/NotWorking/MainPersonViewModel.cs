namespace ClientSideValidationTest.Models.NotWorking
{
    public class MainPersonViewModel : PersonViewModel, IAddress
    {
        public string Postcode { get; set; }

        public string Street { get; set; }
    }
}