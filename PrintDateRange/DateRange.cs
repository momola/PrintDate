using System;
namespace PrintDateRange
{
    public class DateRange  
    {
        protected DateTime FirstDate {get; private set;}
        protected DateTime SecondDate {get; private set;}
        public string RangeDate {get; private set;}
        public DateRange(DateTime FirstDate, DateTime SecondDate)
        {
            this.FirstDate = FirstDate;
            this.SecondDate = SecondDate;
        }

        public string CreateRange()
        {
            SetGreaterDateAsSecond();
            this.RangeDate = "";
            string format = "dd.MM.yyyy";

            if(FirstDate.Year != SecondDate.Year)
            {
                return this.RangeDate= FirstDate.ToString(format) + " - " + SecondDate.ToString(format);
            }
            else
            {
                if(FirstDate.Month != SecondDate.Month)
                {
                     string format2 = "dd.MM";
                     return this.RangeDate = FirstDate.ToString(format2) + " - " + SecondDate.ToString(format);
                }
                else
                {
                    if(FirstDate.Day != SecondDate.Day)
                    {
                        string format2 = "dd";
                        return this.RangeDate = FirstDate.ToString(format2) + " - " + SecondDate.ToString(format);
                    }
                    else
                    {
                        return RangeDate= FirstDate.ToString(format);
                    }
                }
            }
        }

        public void PrintRange()
        {
            Console.WriteLine(FirstDate);
            Console.WriteLine(SecondDate);
        }
        
        private void SetGreaterDateAsSecond()
        {
           int result = DateTime.Compare(FirstDate, SecondDate);
            if(result > 0)
            {
                var temp= FirstDate;
                FirstDate =SecondDate;
                SecondDate = temp;
            }
        }
        

    }
}