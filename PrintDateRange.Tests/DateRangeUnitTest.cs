using System;
using Xunit;

namespace PrintDateRange.Tests
{
    public class DateRangeUnitTest
    {

        [Theory]
        [InlineData("02/07/2018", "02/07/2018", "02.07.2018")]
        [InlineData("02/03/2018", "05/03/2018", "02 - 05.03.2018")]
        [InlineData("05/03/2018", "02/03/2018", "02 - 05.03.2018")]
        [InlineData("02/03/2018", "02/07/2018", "02.03 - 02.07.2018")]
        [InlineData("02/03/2017", "02/07/2018", "02.03.2017 - 02.07.2018")]
        public void GetCorrectRangeTest(string firstDate, string secondDate, string expectedRange)
        {
            DateRange range = new DateRange(DateRange.ConvertToDate(firstDate), DateRange.ConvertToDate(secondDate));
            range.FullDate = range.CreateRange();

            Assert.Equal(expectedRange, range.FullDate);
        }
    }
}
