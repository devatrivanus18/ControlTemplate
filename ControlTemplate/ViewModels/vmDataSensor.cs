using ControlTemplate.Models;
using System.Collections.ObjectModel;
using ControlTemplate.Services;

namespace ControlTemplate.ViewModels
{
    public partial class vmDataSensor : BaseViewModel
    {
        private ObservableCollection<tblDataSensor> _dataSensor = new ObservableCollection<tblDataSensor>();
        
        public ObservableCollection<tblDataSensor> DataSensors { get => _dataSensor; set => SetProperty(ref _dataSensor, value); }

        IDataService DataService;
        public vmDataSensor()
        {
            DataService = new DataService();
            DataSensors = DataService.DataSensor;
        }

    }
}
