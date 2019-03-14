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

        public string CreateRange()
        {
            SetGreaterDateAsSecond();
            string mainFormat = "dd.MM.yyyy";
            string ddMMformat = "dd.MM";
            string ddFormat = "dd";
            if(FirstDate.Year != SecondDate.Year)
            {
                return FirstDate.ToString(mainFormat) + " - " + SecondDate.ToString(mainFormat);
            }
            else
            {
                if(FirstDate.Month != SecondDate.Month)
                {
                     return FirstDate.ToString(ddMMformat) + " - " + SecondDate.ToString(mainFormat);
                }
                else
                {
                    if(FirstDate.Day != SecondDate.Day)
                    {
                        return FirstDate.ToString(ddFormat) + " - " + SecondDate.ToString(mainFormat);
                    }
                    else
                    {
                        return FirstDate.ToString(mainFormat);
                    }
                }
            }
        }

        private void SetGreaterDateAsSecond()
        {
            int result = DateTime.Compare(this.FirstDate, this.SecondDate);
            if(result > 0)
            {
                var temp= this.FirstDate;
                this.FirstDate =this.SecondDate;
                this.SecondDate = temp;
            }
        }

        public static DateTime ConvertToDate(string dateString)
        {
            DateTime.TryParse(dateString, out var date);
            return date;
        }
    }
}