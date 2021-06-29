using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
       ValuesController c  = new ValuesController();
          [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = c.Get(1);
            Assert.Equal("ismail mlayeh",returnValue );

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
