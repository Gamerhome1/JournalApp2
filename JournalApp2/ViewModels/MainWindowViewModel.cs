using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp2.ViewModels.Base;

namespace JournalApp2.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string title = "УП наше крутое";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}
