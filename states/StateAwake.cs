using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerState.states
{
    public class StateAwake : State
    {

        public override void HandleClickPowerButton()
        {
            base.HandleClickPowerButton();
            _computer.ChangeState(new StateAsleep());
        }

        public override void HandleKeepPressedPowerButton()
        {
            base.HandleKeepPressedPowerButton();
            _computer.ChangeState(new StateSwitchedOff());
        }
    }
}
