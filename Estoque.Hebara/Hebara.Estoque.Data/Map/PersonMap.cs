using FluentNHibernate.Mapping;
using Hebara.Celular.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hebara.Estoque.Data.Map
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Name).Column("Name");
            HasMany(x => x.Devices).KeyColumn("PersonId").Cascade.All();
  
        }
    }
}
