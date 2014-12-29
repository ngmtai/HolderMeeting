using System;
using System.Collections.Generic;
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
            try
            {
                var holderMeetingEntities = new HolderMeetingEntities(BoConstant.Config.ConnectionString);
                holderMeetingEntities.Database.Connection.Open();
                return true;
            }
            catch { }

            return false;
        }
    }
}
