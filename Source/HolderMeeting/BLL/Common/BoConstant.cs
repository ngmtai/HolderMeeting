using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BLL.Common
{
    public class BoConstant
    {
        public class Config
        {
            //public static string ConnectionString = ConfigurationManager.ConnectionStrings["HolderMeetingEntities"].ConnectionString;

            public static string ConnectionString =
                "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={0};initial catalog=HolderMeeting;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        }

        public enum AnswerType
        {
            No = 0,
            Yes = 1,
            Other = 2
        }
    }
}
