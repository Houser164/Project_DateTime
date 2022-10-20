namespace Test;

public class UnitTest1
{
     public DateTimes dateTime = new DateTimes();
    [Fact]
    public void TestTime()
    {
       
        Assert.IsType<TimeOnly>(dateTime.GetTime());

    }
    [Fact]
    public void TestDate()
    {
       
        Assert.IsType<DateOnly>(dateTime.GetDate());

    }
}