using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleCalculateDateEnd
{
    class MyDate 
    {
        public DateTime DateBeg {get;set;}
        public DateTime DateEnd {get;set;}
        public int DayCount { get; set;}
        public void CalcAndSetDayCount()
        {
            CalcAndSetDayCount(DateBeg, DateEnd);
        }
        public void CalcAndSetDayCount(DateTime ADateBeg, DateTime ADateEnd)
        {
            DayCount = CalcDayCount(ADateBeg, ADateEnd);
        }
        public int CalcDayCount()
        {
            TimeSpan lDateDelta = DateEnd - DateBeg;
            // Difference in days.
            int lDifferenceInDays = lDateDelta.Days + 1;
            if (lDifferenceInDays <= 0)
            {
                return 0;
            }
            else
            {
                return lDifferenceInDays;
            }
        }
        public int CalcDayCount(DateTime ADateBeg, DateTime ADateEnd)
        {
            TimeSpan lDateDelta = ADateEnd - ADateBeg;
            // Difference in days.
            int lDifferenceInDays = lDateDelta.Days + 1;
            if (lDifferenceInDays <= 0)
            {
                return 0;
            }
            else
            {
                return lDifferenceInDays;
            }
        }
        public MyDate(DateTime ADateBeg, DateTime ADateEnd)
        {
            DateBeg = ADateBeg;
            DateEnd = ADateEnd;
            DayCount = 0;
        }

    }

    class MyDateComparerDateBeg: IComparer<MyDate>
    {
        public int Compare(MyDate AMassiv, MyDate ASearchValue)
        {
            /*
             * AMassiv < ASearchValue  -1
             * AMassiv = ASearchValue   0
             * AMassiv > ASearchValue   1
             */

            if (AMassiv == null)
            {
                if (ASearchValue == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (ASearchValue == null)
                {
                    return 1;
                }
                else
                {
                    if (AMassiv.DateBeg <= ASearchValue.DateBeg && ASearchValue.DateBeg <= AMassiv.DateEnd)
                    {
                        return 0;
                    }
                    else 
                    {
                        if (ASearchValue.DateBeg > AMassiv.DateEnd)
                        {
                            return -1;
                        }
                        else
                        {
                            if (ASearchValue.DateBeg < AMassiv.DateBeg)
                            {
                                return 1;
                            }
                            else
                            {
                                return -1;
                            }

                        }
                    }
                }
            }
        }

    }

    class MyDateComparerDateEnd: IComparer<MyDate>
    {
        public int Compare(MyDate AMassiv, MyDate ASearchValue)
        {
            /*
             * AMassiv < ASearchValue  1
             * AMassiv = ASearchValue  0
             * AMassiv > ASearchValue -1
             */

            if (AMassiv == null)
            {
                if (ASearchValue == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {

                if (ASearchValue == null)
                {
                    return 1;
                }
                else
                {
                    if (ASearchValue == null)
                    {
                        return 1;
                    }
                    else
                    {
                        if (AMassiv.DateBeg <= ASearchValue.DateBeg && ASearchValue.DateBeg <= AMassiv.DateEnd)
                        {
                            return 0;
                        }
                        else
                        {
                            if (ASearchValue.DateBeg > AMassiv.DateEnd)
                            {
                                return -1;
                            }
                            else
                            {
                                if (ASearchValue.DateBeg < AMassiv.DateBeg)
                                {
                                    return 1;
                                }
                                else
                                {
                                    return -1;
                                }

                            }
                        }
                    }                    
                }
            }
        }

    }
    class MyDateArray
    {
        public List<MyDate> DateRanges;
        public void Prepare()
        {
            MyDate lMyDate;
            int i;
            for (i = 0; i < DateRanges.Count; i++)
            {
                lMyDate = DateRanges[i];
                lMyDate.CalcAndSetDayCount();
            }
        }
        public MyDate AddRange(string ADateBeg, string ADateEnd, string ADateTimeFormat)
        {
            DateTime lDateBeg = Convert.ToDateTime(ADateBeg);
            DateTime lDateEnd = Convert.ToDateTime(ADateEnd);
            
            return AddRange(lDateBeg, lDateEnd);
        }
        public MyDate AddRange(DateTime ADateBeg, DateTime ADateEnd)
        {
            MyDate lMyDate = new MyDate(ADateBeg, ADateEnd);
            DateRanges.Add(lMyDate);
            return lMyDate;
        }
        public MyDateArray()
        { 
            DateRanges = new List<MyDate>();
        }
        public int FindDateIndexInRange(DateTime ASourceDataTime)
        {
            MyDate lMyDate = new MyDate(ASourceDataTime, ASourceDataTime);
            MyDateComparerDateBeg lMyDateComparer = new MyDateComparerDateBeg();
            return DateRanges.BinarySearch(lMyDate, lMyDateComparer);            
        }
        public int SumDays(int ABegIndex, int AEndIndex)
        {
            int lSum = 0;
            int i;
            MyDate lMyDate;
            for (i = ABegIndex; i <= AEndIndex; i++)
            {
                lMyDate = DateRanges[i];
                lSum = lSum + lMyDate.DayCount;
            }
            return lSum;
        }
        public string CalculateDateEndStr(DateTime ADateBeg, int ADays, string ADateTimeFormat)
        { 
            DateTime lResult;
            string lStr;
            lResult =  CalculateDateEnd(ADateBeg, ADays);
            lStr = lResult.ToString(ADateTimeFormat);
            return (lStr);
        }
        public DateTime CalculateDateEnd(DateTime ADateBeg, int ADays)
        {
            int j = 1;
            int lIndex = -1;
            int lDayCount = ADays;
            DateTime lDateBeg = ADateBeg;
            while (j != ADays)
            {
                lIndex = FindDateIndexInRange(lDateBeg);
                if (lIndex < 0)
                {
                    j++;
                }
                lDateBeg = lDateBeg.AddDays(1);

            }
            lIndex = FindDateIndexInRange(lDateBeg);
            while (lIndex >= 0)
            {
                lDateBeg = lDateBeg.AddDays(1);
                lIndex = FindDateIndexInRange(lDateBeg);
            }
            return lDateBeg;
        }
    }
}
