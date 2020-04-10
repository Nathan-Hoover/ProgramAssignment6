namespace ProgramAssignment6.Interfaces
{
    public interface IAtmState
    {
        public void InsertCard(string cardNumberString);

        public void EjectCard();

        public void RequestCash(double cashAmount);

        public void InsertPin(string pinString);
    }
}