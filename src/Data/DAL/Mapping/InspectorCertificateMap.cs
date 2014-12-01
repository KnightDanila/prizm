﻿using Domain.Entity;
using Domain.Entity.Setup;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class InspectorCertificateMap : SubclassMap<InspectorCertificate>
    {
        public InspectorCertificateMap()
        {
            Table("InspectorCertificate");
            References(x => x.Inspector).Column("inspectorId");
            //HasMany<Certificate>(x => x.Certificates)
            //    .Component(x => 
            //    {
            //        x.Map(m => m.Number).Column("number");
            //        x.Map(m => m.ExpirationDate).Column("expirationDate");
            //    });
            Component<Certificate>(x => x.Certificate, m =>
            {
                m.Map(x => x.Number).Column("Number");
                m.Map(x => x.ExpirationDate).Column("expirationDate");
            }
    );
            
        }
    }
}
