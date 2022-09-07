using ControlTemplate.Models;
using System.Collections.ObjectModel;
using ControlTemplate.Services;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ControlTemplate.ViewModels
{
    public class vmData : ObservableObject
    {
        private ObservableCollection<tblDataCustomer> _dataCustomers = new ObservableCollection<tblDataCustomer>();

        private string _textFilter;
        public string TextFilter { get => _textFilter; set => SetProperty(ref _textFilter, value); }
        public ObservableCollection<tblDataCustomer> DataCustomers { get => _dataCustomers; set => SetProperty(ref _dataCustomers, value); }
        IDataService DataService;

        public ICommand FilterCommand { get; set; }
        
        public vmData()
        {
            DataService = new DataService();
            FilterCommand = new Command(OnFilterData);
            DataCustomers.Clear();
            DataCustomers = DataService.DataCustomers;
        }

        public async void OnFilterData()
        {
            if (!string.IsNullOrWhiteSpace(_textFilter))
            {
                _textFilter = _textFilter.ToLowerInvariant();
                var filteredData = DataCustomers.Where(x => x.Nama.ToLowerInvariant().Contains(_textFilter)
                                    || x.Prefix.ToLowerInvariant().Contains(_textFilter)).ToList();
                DataCustomers.Clear();
                foreach (var item in filteredData)
                {
                    DataCustomers.Add(item);
                }
            } else {
                DataCustomers.Clear();
                DataCustomers = await DataService.GetData();
            }
            
        }

        

    }
}
