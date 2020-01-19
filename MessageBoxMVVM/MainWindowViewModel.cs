using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MessageBoxMVVM
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "My Title";

        public MainWindowViewModel(IDialogCoordinator dialogCoordinator)
        {
            SayHelloCommand = new DelegateCommand(async () =>
            {
                await dialogCoordinator.ShowMessageAsync(this, "Hello dialog", "Hello!", MessageDialogStyle.Affirmative);
            });
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public DelegateCommand SayHelloCommand { get; }
    }
}
