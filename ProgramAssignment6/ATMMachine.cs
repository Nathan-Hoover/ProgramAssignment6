using System;

using ProgramAssignment6.ATMStates;
using ProgramAssignment6.Interfaces;

namespace ProgramAssignment6
{
    public class AtmMachine
    {
        internal double TotalCashInAtm { get; set; }
        private IAtmState AtmState { get; set; }

        public AtmMachine(double totalCashInAtm)
        {
            TotalCashInAtm = totalCashInAtm;
            SetState(nameof(NoCardAtmState));

            Console.WriteLine($"ATM has {TotalCashInAtm}");
        }

        public void SetState(string stateName)
        {
            switch (stateName)
            {
                case nameof(HasCardAtmState):
                    AtmState = new HasCardAtmState(this);
                    break;

                case nameof(HasPinAtmState):
                    AtmState = new HasPinAtmState(this);
                    break;

                case nameof(NoCardAtmState):
                    AtmState = new NoCardAtmState(this);
                    break;

                case nameof(NoCashAtmState):
                    AtmState = new NoCashAtmState(this);
                    break;
            }
        }

        public void InsertCard(string cardNumberString)
        {
            AtmState.InsertCard(cardNumberString);
        }

        public void EjectCard()
        {
            AtmState.EjectCard();
        }

        public void RequestCash(double cashAmount)
        {
            AtmState.RequestCash(cashAmount);
        }

        public void InsertPin(string pinString)
        {
            AtmState.InsertPin(pinString);
        }
    }
}