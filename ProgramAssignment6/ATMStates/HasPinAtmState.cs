using System;

using ProgramAssignment6.Interfaces;

namespace ProgramAssignment6.ATMStates
{
    public class HasPinAtmState : IAtmState
    {
        private AtmMachine AtmMachine { get; }

        public HasPinAtmState(AtmMachine atmMachine)
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
            AtmMachine.SetState(nameof(HasPinAtmState));
        }

        public void InsertPin(string pinString)
        {
            Console.WriteLine("Pin already entered");
            AtmMachine.SetState(nameof(HasPinAtmState));
        }

        // Assuming that if cash is requested that the ATM system should
        // Show how much cash was requested, Subtract the amount from the ATM, and Eject the card
        public void RequestCash(double cashAmount)
        {
            if (cashAmount < AtmMachine.TotalCashInAtm)
            {
                AtmMachine.SetState(nameof(NoCashAtmState));
            }
            else
            {
                Console.WriteLine($"Cash Requested: {cashAmount}");
                AtmMachine.TotalCashInAtm -= cashAmount;
                EjectCard();
            }
        }
    }
}