using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BLL.Common
{
    public class MyConstant
    {
        public class Config
        {
            public static string connectionString = ConfigurationManager.ConnectionStrings["HolderMeetingEntities"].ConnectionString;
        }

        public enum AnswerType
        {
            No = 0,
            Yes = 1,
            Other = 2
        }
    }
}
