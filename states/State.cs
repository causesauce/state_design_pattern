using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerState.states
{
    public abstract class State
    {
        protected Computer _computer;

        public void SetComputer(Computer computer)
        {
            this._computer = computer;
        }

        public virtual void HandleClickPowerButton()
        {
            Console.WriteLine("Power button was clicked");
        }

        public virtual void HandleKeepPressedPowerButton()
        {
            Console.WriteLine("Power button was held");
        }
    }
}
