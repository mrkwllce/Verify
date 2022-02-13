﻿[TestFixture]
public class Tests
{
    [TestCase("Value1")]
    public Task UseFileNameWithParam(string arg)
    {
        return Verify(arg)
            .UseFileName("UseFileNameWithParam");
    }

    [TestCase("Value1")]
    public Task UseTextForParameters(string arg)
    {
        return Verify(arg)
            .UseTextForParameters("TextForParameter");
    }

    static IEnumerable<int> testCases = Enumerable.Range(0, 3600);

    [TestCaseSource(nameof(testCases))]
    public Task ManyTestCases(int testCase)
    {
        var result = testCase * 2;
        return Verify(result)
            .UseParameters(testCase)
            .UseDirectory("snaps")
            .AutoVerify()
            .DisableDiff();
    }
}