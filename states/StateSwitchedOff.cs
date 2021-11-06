using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerState.states
{
    public class StateSwitchedOff : State
    {

        public override void HandleClickPowerButton()
        {
            base.HandleClickPowerButton();
            _computer.ChangeState(new StateAwake());
        }

        public override void HandleKeepPressedPowerButton()
        {
            base.HandleKeepPressedPowerButton();
            Console.WriteLine("*Nothing happens*");
        }
    }
}
