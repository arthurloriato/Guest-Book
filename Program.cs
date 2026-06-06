namespace GuestBookDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            // WelcomeMessage
            GuestLogic.WelcomeMessage();

            (List<string> guests, int totalGuests) = GuestLogic.GetAllGuests();

            GuestLogic.DisplayGuests(guests);

            GuestLogic.DisplayGuestCount(totalGuests);
        }
    }
}
