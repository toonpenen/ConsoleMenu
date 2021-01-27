﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheekMetMenu.Models
{
    class MainMenuOperation_ExitApp : ConsoleMenuLib.ConsoleMenuOperation
    {
        public override ConsoleMenuReport Execute()
        {
            return new ConsoleMenuReport(this.ToString(), Request.Break);
        }

        protected override ConsoleKey[] GetAssociatedKeys()
        {
            return new ConsoleKey[] { ConsoleKey.E };
        }

        protected override string GetMenuOperationName()
        {
            return "Close application";
        }
    }
}
