using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebara.Celular.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Device> Devices { get; set; }
    }

}
