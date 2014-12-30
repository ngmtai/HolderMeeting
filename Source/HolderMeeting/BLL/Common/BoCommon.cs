using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using DAL;

namespace BLL.Common
{
    public class BoCommon
    {
        public static bool IsConnect()
        {
            var result = false;
            try
            {
                var holderMeetingEntities = new HolderMeetingEntities(BoConstant.Config.ConnectionString);
                holderMeetingEntities.Database.Connection.Open();
                result = true;
                holderMeetingEntities.Database.Connection.Close();
            }
            catch { }

            return result;
        }
    }
}
