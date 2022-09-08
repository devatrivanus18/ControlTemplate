using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace ControlTemplate.ViewModels
{
    public class vmTest : ObservableObject
    {
        private string _testApp = "1234";
        public string testLib { get => _testApp; set => SetProperty(ref _testApp, value); }
        public ICommand SubmitCommand { get; set; }
        public vmTest()
        {
            SubmitCommand = new Command(Submit);
        }

        private void Submit()
        {
            var y = testLib;
        }
    }
}
