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

        public string CreateRange(DateTime FirstDate, DateTime SecondDate)
        {

            this.RangeDate = "";
            return RangeDate;
        }

        public void PrintRange()
        {
            Console.WriteLine(FirstDate);
            Console.WriteLine(SecondDate);
        }
        
    }
}