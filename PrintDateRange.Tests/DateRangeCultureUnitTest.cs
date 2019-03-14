using System;
using Xunit;

namespace PrintDateRange.Tests
{
    public class DateRangeCultureUnitTest
    {

        [Fact]
        [UseCulture("en-US")]
        public void GetCorrectCultureEnUsTest()
        {
            var temDate = DateTime.Now;
            DateRange range = new DateRange(temDate, temDate.AddMonths(+1));

            range.FullDate = range.CreateRange();
            var day = temDate.ToString("dd");
            var month = temDate.ToString("MM");
            var month2 = temDate.AddMonths(+1).ToString("MM");
            var year = temDate.ToString("yyyy");
            Assert.Equal(day+"."+month+" - "+day+"."+month2+"."+year, range.FullDate);
        }

        [Fact]
        [UseCulture("en-NZ")]
        public void GetCorrectCultureEnNzTest()
        {
            var temDate = DateTime.Now;
            DateRange range = new DateRange(temDate, temDate.AddMonths(+1));

            range.FullDate = range.CreateRange();
            var day = temDate.ToString("dd");
            var month = temDate.ToString("MM");
            var month2 = temDate.AddMonths(+1).ToString("MM");
            var year = temDate.ToString("yyyy");
            Assert.Equal(day+"."+month+" - "+day+"."+month2+"."+year, range.FullDate);
        }

        [Fact]
        [UseCulture("de-DE")]
        public void GetCorrectCultureDeDETest()
        {
            var temDate = DateTime.Now;
            DateRange range = new DateRange(temDate, temDate.AddMonths(+1));

            range.FullDate = range.CreateRange();
            var day = temDate.ToString("dd");
            var month = temDate.ToString("MM");
            var month2 = temDate.AddMonths(+1).ToString("MM");
            var year = temDate.ToString("yyyy");
            Assert.Equal(day+"."+month+" - "+day+"."+month2+"."+year, range.FullDate);
        }

        [Fact]
        [UseCulture("pt-BR")]
        public void GetCorrectCulturePtBrTest()
        {
            var temDate = DateTime.Now;
            DateRange range = new DateRange(temDate, temDate.AddMonths(+1));

            range.FullDate = range.CreateRange();
            var day = temDate.ToString("dd");
            var month = temDate.ToString("MM");
            var month2 = temDate.AddMonths(+1).ToString("MM");
            var year = temDate.ToString("yyyy");
            Assert.Equal(day+"."+month+" - "+day+"."+month2+"."+year, range.FullDate);
        }
    }
}
