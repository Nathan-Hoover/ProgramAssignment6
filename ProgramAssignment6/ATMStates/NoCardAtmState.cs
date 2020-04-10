using System;

using ProgramAssignment6.Interfaces;

namespace ProgramAssignment6.ATMStates
{
    public class NoCardAtmState : IAtmState
    {
        private AtmMachine AtmMachine { get; }

        public NoCardAtmState(AtmMachine atmMachine)
        {
            AtmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Error: Card can’t be Ejected – No Card Inserted");
            AtmMachine.SetState(nameof(NoCardAtmState));
        }

        // Assuming that if no cash is in the ATM during an Insert that the ATM should
        // Show an error of no cash, eject the card, and make the state NoCash
        public void InsertCard(string cardNumberString)
        {
            Console.WriteLine($"Card Inserted: {cardNumberString}");
            if (AtmMachine.TotalCashInAtm > 0)
            {
                AtmMachine.SetState(nameof(HasCardAtmState));
            }
            else
            {
                Console.WriteLine("Error: Out of Cash");
                Console.WriteLine("Card Ejected");
                AtmMachine.SetState(nameof(NoCashAtmState));
            }
        }

        public void InsertPin(string pinString)
        {
            Console.WriteLine("No card inserted");
            AtmMachine.SetState(nameof(NoCardAtmState));
        }

        public void RequestCash(double cashAmount)
        {
            Console.WriteLine("No card inserted");
            AtmMachine.SetState(nameof(NoCardAtmState));
        }
    }
}