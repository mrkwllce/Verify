﻿[UsesVerify]
public class WithAttributeTests
{
    [Fact]
    public Task ShouldPass() =>
        Verify("Foo");

    [UsesVerify]
    public class Nested
    {
        [Fact]
        public Task ShouldPass() =>
            Verify("NestedFoo");
    }
}