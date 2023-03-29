using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp2.Infrastructure.Commands.Base;

namespace JournalApp2.Infrastructure.Commands
{
    public class LambdaCommand : Command
    {
        private readonly Action<object> excute;
        private readonly Func<object, bool> canExecute;

        public LambdaCommand(Action<object> Excute, Func<object, bool> CanExecute = null)
        {
            excute = Excute ?? throw new ArgumentNullException(nameof (Excute));
            canExecute = CanExecute;
        }

        public override bool CanExecute(object parametr)
        {
            return canExecute?.Invoke(parametr) ?? true;
        }

        public override void Execute(object parametr)
        {
            excute(parametr);
        }
    }
}
