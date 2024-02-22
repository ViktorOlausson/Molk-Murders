using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MolkMurders.ViewModels {
    public partial class SetupPageViewModel : ObservableObject {

        public ICommand MyCommand { get; private set; }
        
        public SetupPageViewModel() {
            MyCommand = new Command<string>(ExecuteMyCommand);
        }

        private void ExecuteMyCommand(string parameter) {
            // Here, 'parameter' will contain the value of CommandParameters
            Trace.WriteLine($"Command executed with parameter: {parameter}");
        }

    }
}
