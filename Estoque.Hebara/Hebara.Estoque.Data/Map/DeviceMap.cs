using FluentNHibernate.Mapping;
using Hebara.Celular.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebara.Estoque.Data.Map
{
    public class DeviceMap : ClassMap<Device>
    {
        public DeviceMap()
        {
            Table("Device");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Model).Column("Model");
            Map(x => x.Serial).Column("Serial");
            Map(x => x.SerialOffice).Column("SerialOffice");
            Map(x => x.SerialWindows).Column("SerialWindows");
            Map(x => x.Status).CustomType<int>().Column("Status");
            Map(x => x.Type).CustomType<int>().Column("Type");
            References(x => x.Person).Column("PersonId");

        }
    }
}
