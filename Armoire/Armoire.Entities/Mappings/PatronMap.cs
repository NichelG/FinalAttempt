using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace Armoire.Entities.Mappings
{
    public class PatronMap : ClassMap<Patron>
    {
        public PatronMap()
        {
            Table("Patrons");
            Id(x => x.Id).Column("patronsID");
            Map(x => x.FirstName).Column("firstname");
            Map(x => x.LastName).Column("lastname");
            Map(x => x.Username).Column("username");
            Map(x => x.Password).Column("pword");
            Map(x => x.Email).Column("email");
            Map(x => x.Address).Column("address").Nullable();
            Map(x => x.City).Column("city").Nullable();
            Map(x => x.State).Column("state").Nullable();
            Map(x => x.Zip).Column("zip").Nullable();
            Map(x => x.Phone).Column("phone").Nullable();
            Map(x => x.Image).Column("picture").Nullable();
            Map(x => x.AccountStatus).Column("accountStatus");
            Map(x => x.DateCreated).Column("dateCreated");
            Map(x => x.LastUpdated).Column("lastUpdated").Nullable();
            Map(x => x.AccountType).Column("accountType");
            
        }
    }
}
