using High_Level_Interfaces_with_Files_Tutorial_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Level_Interfaces_with_Files_Tutorial_.Commands
{
    public class SwitchStateCommand : ICommand
    {
        private StateManager _manager;
        private IState _newState;

        public SwitchStateCommand(StateManager manager, IState newStatel ) 
        {
            _manager = manager;
            _newState = newStatel;
        }

        public void Execute()
        {
            _manager.SwitchState( _newState );
        }
    }
}
