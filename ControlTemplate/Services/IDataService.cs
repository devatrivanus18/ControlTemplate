using ControlTemplate.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate.Services
{
    public interface IDataService
    {
        tblPerangkat Perangkat { get; set; }
        ObservableCollection<tblDataCustomer> DataCustomers { get; set; }
        ObservableCollection<tblDataTransaksi> DataTransaksi { get; set; }
        ObservableCollection<tblDataSensor> DataSensor { get; set; }
        Task<ObservableCollection<tblDataSensor>> GetData();
        Task OnLogin(string username);
    }
}
