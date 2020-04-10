using System;

using ProgramAssignment6.Interfaces;

namespace ProgramAssignment6.ATMStates
{
    public class NoCashAtmState : IAtmState
    {
        private AtmMachine AtmMachine { get; }

        public NoCashAtmState(AtmMachine atmMachine)
        {
            AtmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Console.WriteLine($"No cash available");
            AtmMachine.SetState(nameof(NoCashAtmState));
        }

        public void InsertCard(string cardNumberString)
        {
            Console.WriteLine($"No cash available");
            AtmMachine.SetState(nameof(NoCashAtmState));
        }

        public void InsertPin(string pinString)
        {
            Console.WriteLine($"No cash available");
            AtmMachine.SetState(nameof(NoCashAtmState));
        }

        public void RequestCash(double cashAmount)
        {
            Console.WriteLine($"No cash available");
            AtmMachine.SetState(nameof(NoCashAtmState));
        }
    }
}