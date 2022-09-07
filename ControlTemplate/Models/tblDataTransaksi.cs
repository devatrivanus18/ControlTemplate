using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTemplate.Models
{
    public class tblDataTransaksi
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public int TotalTransaksi { get; set; }
        public string Tanggal { get; set; }
    }
}
