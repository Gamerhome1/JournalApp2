using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp2.ViewModels.Base;
using JournalApp2.Infrastructure.Commands;
using System.Windows.Input;
using System.Windows;

namespace JournalApp2.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title = "УП наше крутое";

        /// <summary>
        /// Заголовок окна
        /// </summary>

        #region Команды

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExcuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExcute(object p)
        {
            return true;
        }

        #endregion
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExcuted, CanCloseApplicationCommandExcute);
        }
    }
}
