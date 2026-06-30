using High_Level_Interfaces_with_Files_Tutorial_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Level_Interfaces_with_Files_Tutorial_.Commands
{
    public class InvalidCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("InvalidCommand");
        }
    }
}
