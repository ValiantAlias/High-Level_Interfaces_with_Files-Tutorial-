using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using High_Level_Interfaces_with_Files_Tutorial_.Abstract;

namespace High_Level_Interfaces_with_Files_Tutorial_.Commands
{
    public class HelpCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("HELP!!!!!");
        }
    }
}
