using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate.Models
{
    public class tblDataSensor
    {
        public int IdDataSensor { get; set; }
        public int IdPerangkat { get; set; }
        public string Suhu { get; set; }
        public string Kelembaban { get; set; }
        public string? Tanggal { get; set; }
        public string? Waktu { get; set; }
    }
}
