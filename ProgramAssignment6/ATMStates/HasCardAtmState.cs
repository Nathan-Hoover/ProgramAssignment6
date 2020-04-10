using System;

using ProgramAssignment6.Interfaces;

namespace ProgramAssignment6.ATMStates
{
    public class HasCardAtmState : IAtmState
    {
        private AtmMachine AtmMachine { get; }

        public HasCardAtmState(AtmMachine atmMachine)
        {
            AtmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine("Card Ejecting");
            AtmMachine.SetState(nameof(NoCardAtmState));
        }

        public void InsertCard(string cardNumberString)
        {
            Console.WriteLine("There is already a card inserted");
            AtmMachine.SetState(nameof(HasCardAtmState));
        }

        public void InsertPin(string pinString)
        {
            Console.WriteLine($"Pin Entered: {pinString}");
            AtmMachine.SetState(nameof(HasPinAtmState));
        }

        public void RequestCash(double cashAmount)
        {
            Console.WriteLine($"Please enter Pin");
            AtmMachine.SetState(nameof(HasCardAtmState));
        }
    }
}