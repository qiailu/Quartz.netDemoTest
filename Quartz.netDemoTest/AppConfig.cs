using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System;

namespace Quartz.netDemoTest
{
    public class AppConfig
    {
        public static int Trigger1InSecounds
        {
            get
            {
                int secs = 0;
                var secounds = ConfigurationManager.AppSettings["Trigger1InSecounds"];

                if (!string.IsNullOrWhiteSpace(secounds))
                {
                    int.TryParse(secounds, out secs);
                }

                return secs <= 0 ? 2 : secs;
            }
        }

        public static int Trigger2InSecounds
        {
            get
            {
                int secs = 0;
                var secounds = ConfigurationManager.AppSettings["Trigger2InSecounds"];

                if (!string.IsNullOrWhiteSpace(secounds))
                {
                    int.TryParse(secounds, out secs);
                }

                return secs <= 0 ? 3 : secs;
            }
        }
    }
}
