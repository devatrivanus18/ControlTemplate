using Microsoft.Toolkit.Mvvm.ComponentModel;


namespace ControlTemplate.Models
{
    public class tblDataCustomer : ObservableObject
    {
        public int Id { get; set; }
        private string _prefix;
        public string Prefix { get => _prefix; set => SetProperty(ref _prefix, value); }

        private string _nama;
        public string Nama { get => _nama; set => SetProperty(ref _nama, value); }
    }
}
