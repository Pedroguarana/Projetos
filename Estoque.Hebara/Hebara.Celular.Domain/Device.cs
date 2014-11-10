using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebara.Celular.Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public StatusType Status { get; set; }  
        public string Serial { get; set; }
        public string SerialWindows { get; set; }
        public string SerialOffice { get; set; }
        public List<Acessory> Acessories { get; set; }
        public DeviceType Type { get; set; }
        public Person Person { get; set; }

        public enum StatusType
        {
            WellFunction = 1,
            Malfunction = 2,
            Missing = 3
        }
        public enum DeviceType
        {
            Pendrive = 1,
            Notebook = 2,
            Mobile = 3,
            Tablet = 4,
            Computer = 5,
            Monitor = 6,
            Teclado = 7,
            Mouse = 8,
            Barcode = 9,
            Hd = 10,
            PowerSupply = 11,
            DRam = 12,
            DvdRom = 13,
            Switch = 14,




        }
    }
}
