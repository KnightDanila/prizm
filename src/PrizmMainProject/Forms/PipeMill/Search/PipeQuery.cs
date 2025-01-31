﻿using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using NHibernate.Transform;
using Prizm.Main.Common;
using Prizm.Main.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.Search
{
    public class PipeQuery : IResultTransformer
    {
        public static readonly PipeQuery Transformer = new PipeQuery();

        private PipeQuery() { }



        public IList TransformList(IList collection)
        {
            return collection;
        }

        public object TransformTuple(object[] tuple, string[] aliases)
        {
            var pipe = new Pipe();

            pipe.Id = (Guid)tuple[0];
            pipe.Number = (string)tuple[1];
            pipe.HeatNumber = (string)tuple[2];
            pipe.Mill = (string)tuple[3];
            pipe.ProductionDate = (DateTime)tuple[4];
            pipe.PipeMillStatus = (string)tuple[5];
            pipe.IsActive = (bool)tuple[6];
            pipe.PurchaseOrderNumber = (string)tuple[7];
            pipe.Type = (string)tuple[8];

            return pipe;
        }


        internal static string BuildSql(
            string Number,
            IList<PipeMillSizeType> CheckedPipeTypes,
            ActivityCriteria Activity,
            HashSet<PipeMillStatus> CheckedStatusTypes)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(
                @"  SELECT 
                        [Pipe].[id] as Id, 
                        [Pipe].[number],
                        [Heat].[number] as HeatNumber,
                        [Pipe].[mill] as Mill, 
                        [Pipe].[productionDate],
                        [Pipe].[pipeMillStatus] as PipeMillStatus,
                        [Pipe].[isActive],
                        [PurchaseOrder].[number] as PurchaseOrderNumber,
                        [PipeMillSizeType].[type] as [Type]
                    FROM 
                        [Pipe] join [Plate] on ([Plate].[id] = [Pipe].[plateId]) 
                         join [Heat] on ([Heat].[id] = [Plate].[heatId]) 
                         left join [PurchaseOrder] on ([PurchaseOrder].[id] = [Pipe].[purchaseOrderId])
                         left join [PipeMillSizeType] on ([PipeMillSizeType].[id] = [Pipe].[typeId]) ");

            sb.Append(string.Format(@" WHERE [Pipe].[number] LIKE N'%{0}%' ESCAPE '\' ", Number.EscapeCharacters()));

            if (CheckedPipeTypes.Count > 0)
            {
                sb.Append(" AND [Pipe].[typeId] IN (");
                foreach (var t in CheckedPipeTypes)
                {
                    sb.Append(string.Format("  N'{0}',", t.Id.ToString()));
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(" )");
            }

            if (Activity == ActivityCriteria.StatusActive)
            {
                sb.Append(string.Format(" AND [Pipe].[isActive] = N'{0}'", true));
            }
            else if (Activity == ActivityCriteria.StatusUnactive)
            {
                sb.Append(string.Format(" AND [Pipe].[isActive] = N'{0}'", false));
            }

            if (CheckedStatusTypes.Count > 0)
            {
                sb.Append(" AND PipeMillStatus IN (");
                foreach (var s in CheckedStatusTypes)
                {
                    sb.Append(string.Format("  N'{0}',", Enum.GetName(typeof(PipeMillStatus),s)));
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(" )");
            }

            return sb.ToString();
        }
    }
}
