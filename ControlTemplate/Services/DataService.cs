using ControlTemplate.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using ControlTemplate.Views;
using Grpc.Net.Client.Web;
using Grpc.Net.Client;
using gRPCAutomasiKandang;

namespace ControlTemplate.Services
{
    public class DataService : ObservableObject, IDataService
    {
        private ObservableCollection<tblDataSensor> _dataSensor = new ObservableCollection<tblDataSensor>();
        public ObservableCollection<tblDataSensor> DataSensor { get => _dataSensor; set => SetProperty(ref _dataSensor, value); }

        private ObservableCollection<tblDataCustomer> _dataCustomer = new ObservableCollection<tblDataCustomer>();
        public ObservableCollection<tblDataCustomer> DataCustomers { get => _dataCustomer; set => SetProperty(ref _dataCustomer, value); }

        private ObservableCollection<tblDataTransaksi> _dataTransaksi = new ObservableCollection<tblDataTransaksi>();
        public ObservableCollection<tblDataTransaksi> DataTransaksi { get => _dataTransaksi; set => SetProperty(ref _dataTransaksi, value); }


        public tblPerangkat Perangkat { get; set; }
        public string Token;
        public DataService()
        {
            Perangkat = new tblPerangkat();
            DataCustomers.Add(new tblDataCustomer { Id = 1, Prefix = "CV", Nama = "Duta Karya Pertiwi"});
            DataCustomers.Add(new tblDataCustomer { Id = 2, Prefix = "Bapak", Nama = "Arkan Hautami" });
            DataCustomers.Add(new tblDataCustomer { Id = 3, Prefix = "Ibu", Nama = "Raina" });
            DataCustomers.Add(new tblDataCustomer { Id = 4, Prefix = "Bapak", Nama = "Ahmad" });
            DataCustomers.Add(new tblDataCustomer { Id = 5, Prefix = "Ibu", Nama = "Ningsih" });

            DataTransaksi.Add(new tblDataTransaksi { Id=1, Customer="Arkan Hautami", TotalTransaksi = 50000, Tanggal="19-08-2022"});
            //GetData();
        }

        public async Task<ObservableCollection<tblDataCustomer>> GetData()
        {
            /*try
            {
                var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                var channel = GrpcChannel.ForAddress("https://myuserdo.azurewebsites.net/", new GrpcChannelOptions { HttpClient = httpClient });
                var client = new DataSensor.DataSensorClient(channel);
                var request = new DataRequest { IdPerangkat = 1 };
                using (var reply = client.GetSemuaData(request))
                    while (await reply.ResponseStream.MoveNext(System.Threading.CancellationToken.None))
                    {
                        DataResponse data = reply.ResponseStream.Current;
                        DataSensor.Add(new tblDataSensor
                        {
                            IdDataSensor = (int)data.IdDataSensor,
                            IdPerangkat = (int)data.IdPerangkat,
                            Suhu = data.Suhu,
                            Kelembaban = data.Kelembaban,
                            Tanggal = data.Tanggal,
                            Waktu = data.Waktu,
                        });
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            DataCustomers.Add(new tblDataCustomer { Id = 1, Prefix = "CV", Nama = "Duta Karya Pertiwi" });
            DataCustomers.Add(new tblDataCustomer { Id = 2, Prefix = "Bapak", Nama = "Arkan Hautami" });
            DataCustomers.Add(new tblDataCustomer { Id = 3, Prefix = "Ibu", Nama = "Raina" });
            DataCustomers.Add(new tblDataCustomer { Id = 4, Prefix = "Bapak", Nama = "Ahmad" });
            DataCustomers.Add(new tblDataCustomer { Id = 5, Prefix = "Ibu", Nama = "Ningsih" });

            return DataCustomers;
        }

        public async Task OnLogin(string username)
        {
            try
            {
                /*var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                var channel = GrpcChannel.ForAddress("https://myuserdo.azurewebsites.net/", new GrpcChannelOptions { HttpClient = httpClient });
                var client = new LoginToken.LoginTokenClient(channel);
                var clientRequested = new LoginTokenRequest { NomorSeri = username };
                var reply = await client.GetLoginTokenAsync(clientRequested);
                Token = reply.Token;
                Perangkat.IdPerangkat = (int)reply.IdPerangkat;
                Perangkat.No_Serial = reply.NomorSeri;
                Perangkat.StatusAir = (int)reply.StatusAir;
                Perangkat.StatusPakan = (int)reply.StatusPakan;
                Perangkat.StatusPerangkat = (int)reply.StatusPerangkat;
                //if (!string.IsNullOrEmpty(Token)) { await GetDataSensor(); }*/
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
