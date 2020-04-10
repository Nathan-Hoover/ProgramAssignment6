namespace ProgramAssignment6
{
    public class Program
    {
        private static void Main()
        {
            var atmMachine = new AtmMachine(2000);
            atmMachine.InsertCard("1234 5678 0000 1111");
            atmMachine.EjectCard();
            atmMachine.InsertCard("1234 5678 0000 2222");
            atmMachine.InsertPin("1234");
            atmMachine.RequestCash(2000);
            atmMachine.EjectCard();
            atmMachine.InsertCard("1234 5678 0000 2222");
        }
    }
}