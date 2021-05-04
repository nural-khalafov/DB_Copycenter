using System;

namespace DB_Copycenter
{
    public static class Time
    {
        public static DateTime PaymentTime
        {
            get
            {
                var time = DateTime.Now;

                return time;
            }
        }

        public static DateTime ReportTime
        {
            get
            {
                var time = DateTime.Now;

                return time;
            } 

        }
    }
}