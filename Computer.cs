using ComputerState.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerState
{
    public class Computer
    {
        private State _state = null;

        public Computer(State state)
        {
            this._state = state;
            state.SetComputer(this);
            Console.WriteLine($"Computer's initial state: {state.GetType().Name}");
        }

        public void ChangeState(State state)
        {
            var oldState = this._state;
            this._state = state;
            this._state.SetComputer(this);
            Console.WriteLine($"Computer: {oldState.GetType().Name} changed to {state.GetType().Name}");
        }


        public void ClickPowerButton()
        {
            this._state.HandleClickPowerButton();
        }

        public void KeepPressedPowerButton()
        {
            this._state.HandleKeepPressedPowerButton();
        }

    }
}
