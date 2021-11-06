using ComputerState.states;
using System;

namespace ComputerState
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(new StateAwake());
            computer.KeepPressedPowerButton();
            computer.KeepPressedPowerButton();
            computer.ClickPowerButton();
            computer.ClickPowerButton();
            computer.KeepPressedPowerButton();
        }
    }
}
