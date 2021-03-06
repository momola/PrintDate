using System;
namespace PrintDateRange
{
    public class DateRange  
    {
        public DateTime FirstDate {get; private set;}
        public DateTime SecondDate {get; private set;}
        public string FullDate {get; set;}
        public DateRange(DateTime FirstDate, DateTime SecondDate)
        {
            this.FirstDate = FirstDate;
            this.SecondDate = SecondDate;
        }

        public string CreateRange(DateTime firstDate, DateTime secondDate)
        {
            SetGreaterDateAsSecond(ref firstDate, ref secondDate);
            string format = "dd.MM.yyyy";
            string tempFormat;             
            if(firstDate.Year != secondDate.Year)
            {
                return firstDate.ToString(format) + " - " + secondDate.ToString(format);
            }
            else
            {
                if(firstDate.Month != secondDate.Month)
                {
                     tempFormat = "dd.MM";
                     return firstDate.ToString(tempFormat) + " - " + secondDate.ToString(format);
                }
                else
                {
                    if(firstDate.Day != secondDate.Day)
                    {
                        tempFormat = "dd";
                        return firstDate.ToString(tempFormat) + " - " + secondDate.ToString(format);
                    }
                    else
                    {
                        return firstDate.ToString(format);
                    }
                }
            }
        }
        
        private void SetGreaterDateAsSecond(ref DateTime firstDate, ref DateTime secondDate)
        {
            int result = DateTime.Compare(firstDate, secondDate);
            if(result > 0)
            {
                var temp= firstDate;
                firstDate =secondDate;
                secondDate = temp;
            }
        }
        
        public static DateTime ConvertToDate(string dateString)
        {
            DateTime.TryParse(dateString, out var date);           
            return date;
        }
    }
}