using System.Windows.Input;

namespace ControlTemplate.ViewModels
{
    public class vmTest
    {
        public string testApp { get; set; }
        public string testLib { get; set; }
        public ICommand SubmitCommand { get; set; }
        public vmTest()
        {
            SubmitCommand = new Command(Submit);
        }

        private void Submit()
        {
            var x = testApp;
            var y = testLib;
        }
    }
}
