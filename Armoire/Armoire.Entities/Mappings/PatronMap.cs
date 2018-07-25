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
            Id(x => x.Id).Column("PatronsID");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Username).Column("Username");
            Map(x => x.Password).Column("Pword");
            Map(x => x.Email).Column("Email");
            Map(x => x.Address).Column("Address").Nullable();
            Map(x => x.City).Column("City").Nullable();
            Map(x => x.State).Nullable();
            Map(x => x.Zip).Column("Zip").Nullable();
            Map(x => x.Phone).Column("Phone").Nullable();
            Map(x => x.Image).Column("Picture").Nullable();
            Map(x => x.AccountStatus).Column("AccountStatus");
            Map(x => x.DateCreated).Column("DateCreated");
            Map(x => x.LastUpdated).Column("LastUpdated").Nullable();
            Map(x => x.AccountType);
            //References(x => x.AccountType)
            //    .Column("TypeID")
            //    .ForeignKey("TypeID");
        }
    }
}
