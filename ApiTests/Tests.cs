using Xunit;
using Api.Controllers;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            var api = new ValuesController();

            var result = api.Get(1);

            Assert.Equal("value", result);
        }
    }
}
