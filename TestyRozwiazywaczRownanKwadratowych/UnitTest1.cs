public class TestyRozwiazywaczRownanKwadratowych
{
    [Theory]
    [InlineData(1, -3, 2, 1, 2)]
    [InlineData(1, 2, 1, -1, null)]
    [InlineData(1, 1, 1, null, null)]
    public void RozwiazRownanieKwadratowe_PoprawneWyniki(double a, double b, double c, double? spodziewaneX1, double? spodziewaneX2)
    {
        var (x1, x2) = RozwiazywaczRownanKwadratowych.RozwiazRownanieKwadratowe(a, b, c);
        Assert.Equal(spodziewaneX1, x1);
        Assert.Equal(spodziewaneX2, x2);
    }
}
