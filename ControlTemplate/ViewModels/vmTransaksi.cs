using ControlTemplate.Models;
using ControlTemplate.Services;
using ControlTemplate.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ControlTemplate.ViewModels
{
    public partial class vmTransaksi : BaseViewModel
    {
        private ObservableCollection<tblDataTransaksi> _dataTransaksi = new ObservableCollection<tblDataTransaksi>();

        public ObservableCollection<tblDataTransaksi> DataTransaksi { get => _dataTransaksi; set => SetProperty(ref _dataTransaksi, value); }

        IDataService DataService;

        public ICommand GetModalCommand { get; set; }

        public vmTransaksi()
        {
            DataService = new DataService();
            GetModalCommand = new Command(GetModal);
            DataTransaksi = DataService.DataTransaksi;
        }

        public async void GetModal()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new ModalCustomer());
        }
    }
}
