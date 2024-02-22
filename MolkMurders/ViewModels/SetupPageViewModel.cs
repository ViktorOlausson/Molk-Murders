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

        public ICommand EditCharacterCommand { get; private set; }
        
        public SetupPageViewModel() {
            EditCharacterCommand = new Command<string>(ExecuteMyCommand);
        }

        private void ExecuteMyCommand(string parameter) {
            Trace.WriteLine($"Den här knappen har en paramter, och den är {parameter}!");
        }

    }
}
