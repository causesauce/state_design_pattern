using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerState.states
{
    public class StateAsleep : State
    {

        public override void HandleClickPowerButton()
        {
            base.HandleKeepPressedPowerButton();
            _computer.ChangeState(new StateAwake());
        }

        public override void HandleKeepPressedPowerButton()
        {
            base.HandleKeepPressedPowerButton();
            _computer.ChangeState(new StateSwitchedOff());
        }
    }
}
