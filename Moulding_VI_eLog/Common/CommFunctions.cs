using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  static class CommFunctions
    {
        public static int weekofyear(DateTime dtime)
        {
            int weeknum = 0;
            DateTime tmpdate = DateTime.Parse(dtime.Year.ToString() + "-1" + "-1");
            DayOfWeek firstweek = tmpdate.DayOfWeek;
            //if(firstweek) 
            for (int i = (int)firstweek + 1; i <= dtime.DayOfYear; i = i + 7)
            {
                weeknum = weeknum + 1;
            } 
            return weeknum;
        }
        public static int monthofyearByWeek(int week)
        {
            string Month = "0";
            switch (week)
            {
                case (1): { Month = "1"; break; }
                case (2): { Month = "1"; break; }
                case (3): { Month = "1"; break; }
                case (4): { Month = "1"; break; }
                case (5): { Month = "1"; break; }
                case (6): { Month = "2"; break; }
                case (7): { Month = "2"; break; }
                case (8): { Month = "2"; break; }
                case (9): { Month = "2"; break; }
                case (10): { Month = "3"; break; }
                case (11): { Month = "3"; break; }
                case (12): { Month = "3"; break; }
                case (13): { Month = "3"; break; }
                case (14): { Month = "4"; break; }
                case (15): { Month = "4"; break; }
                case (16): { Month = "4"; break; }
                case (17): { Month = "4"; break; }
                case (18): { Month = "4"; break; }
                case (19): { Month = "5"; break; }
                case (20): { Month = "5"; break; }
                case (21): { Month = "5"; break; }
                case (22): { Month = "5"; break; }
                case (23): { Month = "6"; break; }
                case (24): { Month = "6"; break; }
                case (25): { Month = "6"; break; }
                case (26): { Month = "6"; break; }
                case (27): { Month = "7"; break; }
                case (28): { Month = "7"; break; }
                case (29): { Month = "7"; break; }
                case (30): { Month = "7"; break; }
                case (31): { Month = "7"; break; }
                case (32): { Month = "8"; break; }
                case (33): { Month = "8"; break; }
                case (34): { Month = "8"; break; }
                case (35): { Month = "8"; break; }
                case (36): { Month = "9"; break; }
                case (37): { Month = "9"; break; }
                case (38): { Month = "9"; break; }
                case (39): { Month = "9"; break; }
                case (40): { Month = "10"; break; }
                case (41): { Month = "10"; break; }
                case (42): { Month = "10"; break; }
                case (43): { Month = "10"; break; }
                case (44): { Month = "10"; break; }
                case (45): { Month = "11"; break; }
                case (46): { Month = "11"; break; }
                case (47): { Month = "11"; break; }
                case (48): { Month = "11"; break; }
                case (49): { Month = "12"; break; }
                case (50): { Month = "12"; break; }
                case (51): { Month = "12"; break; }
                case (52): { Month = "12"; break; }
                case (53): { Month = "12"; break; }
                default:
                    {
                        Month = "0"; break;
                    }

            }
            return int.Parse(Month);
        }
        public static int yearByWeek(int year, decimal week)
        {
            return year;
        }

        public static DateTime weekFirstDateofYear(string year , int ww)
        {
             
            DayOfWeek firstweek = DateTime.Parse(year + "-01-01").DayOfWeek;
            DateTime dateT  = DateTime.Parse(year + "-01-01").AddDays((ww - 1) * 7); 

            return dateT.AddDays(-((int)firstweek) + 1);

        }

        public static bool hasWW53(string Year)
        {
            return false;
        }
        public static string DateToString_byDay(DateTime x)
        {
            return x.ToString("yyyy-MM-dd");
        }

        public static int dayOfWeek(DateTime dTime)
        {
            int weekday = 0;
            switch (dTime.DayOfWeek)
            {
                case (DayOfWeek.Monday):
                    {
                        weekday = 1;
                        break;
                    }

                case (DayOfWeek.Tuesday):
                    {
                        weekday = 2;
                        break;
                    }

                case (DayOfWeek.Wednesday):
                    {
                        weekday = 3;
                        break;
                    }

                case (DayOfWeek.Thursday):
                    {
                        weekday = 4;
                        break;
                    }

                case (DayOfWeek.Friday):
                    {
                        weekday = 5;
                        break;
                    }

                case (DayOfWeek.Saturday):
                    {
                        weekday = 6;
                        break;
                    }

                case (DayOfWeek.Sunday):
                    {
                        weekday = 7;
                        break;
                    }
                
            }
            return weekday;
        }
    }
}
