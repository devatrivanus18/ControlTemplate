using ControlTemplate.Models;
using ControlTemplate.Services;
using System.Windows.Input;

namespace ControlTemplate.ViewModels
{
    public partial class vmLogin : BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        

        public tblPerangkat Perangkat = new tblPerangkat();
        public string Token;
        public ICommand LoginCommand { get; set; }

        IDataService DataService;
        public vmLogin()
        {
            DataService = new DataService();
            LoginCommand = new Command(Login);
        }

        

        public async void Login()
        {
            await DataService.OnLogin(Username);
            
        }
    }
}
