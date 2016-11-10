using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalculateDateEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDateArray lDateRange = new MyDateArray();
            string lDateTimeFormat = "dd'/'MM'/'yyyy";
            DateTime lDateBeg = new DateTime(2014,12,29);
            string lDateEnd = "";
            int lDayCount;
            lDateRange.AddRange("11/11/2014", "11/11/2014", lDateTimeFormat);
            lDateRange.AddRange("14/11/2014", "15/11/2014", lDateTimeFormat);
            lDateRange.AddRange("18/11/2014", "18/11/2014", lDateTimeFormat);
            lDateRange.AddRange("19/11/2014", "19/11/2014", lDateTimeFormat);
            lDateRange.AddRange("20/11/2014", "21/11/2014", lDateTimeFormat);
            lDateRange.AddRange("23/11/2014", "23/11/2014", lDateTimeFormat);
            lDateRange.AddRange("24/11/2014", "24/11/2014", lDateTimeFormat);
            lDateRange.AddRange("27/11/2014", "27/11/2014", lDateTimeFormat);
            lDateRange.AddRange("28/11/2014", "28/11/2014", lDateTimeFormat);

            lDateRange.AddRange("30/11/2014", "02/12/2014", lDateTimeFormat);
            lDateRange.AddRange("04/12/2014", "04/12/2014", lDateTimeFormat);
            lDateRange.AddRange("06/12/2014", "07/12/2014", lDateTimeFormat);
            lDateRange.AddRange("08/12/2014", "10/12/2014", lDateTimeFormat);
            lDateRange.AddRange("12/12/2014", "12/12/2014", lDateTimeFormat);
            lDateRange.AddRange("15/12/2014", "17/12/2014", lDateTimeFormat);
            lDateRange.AddRange("18/12/2014", "19/12/2014", lDateTimeFormat);                     
            lDateRange.Prepare();

            lDayCount = 5;
            Console.WriteLine("lDayCount = {0}", lDayCount);            

            lDateBeg = new DateTime(2014, 11, 1);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 9);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 14);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 15);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 18);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 19);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 20);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 23);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 27);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 1);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 4);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 8);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 12);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 15);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 18);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 21);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDayCount = 1;
            Console.WriteLine("lDayCount = {0}", lDayCount);            

            lDateBeg = new DateTime(2014, 11, 1);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 9);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 14);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 15);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 18);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 19);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 20);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 23);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 11, 27);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 1);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 4);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 8);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 12);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 15);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 18);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");

            lDateBeg = new DateTime(2014, 12, 21);
            Console.WriteLine("DateBeg : " + lDateBeg.ToString(lDateTimeFormat));
            lDateEnd = lDateRange.CalculateDateEndStr(lDateBeg, lDayCount, lDateTimeFormat);
            Console.WriteLine("DateEnd : " + lDateEnd);
            Console.WriteLine(" ");
        }
    }
}
