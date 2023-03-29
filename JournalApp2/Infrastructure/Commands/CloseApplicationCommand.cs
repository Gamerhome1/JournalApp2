using JournalApp2.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JournalApp2.Infrastructure.Commands
{
    public class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parametr)
        {
            return true;
        }

        public override void Execute(object parametr)
        {
            Application.Current.Shutdown();
        }
    }
}
