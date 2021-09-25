using FluentAssertions;
using System.Linq;
using Xunit;

namespace Stratis.ChallengeApp.Tests.Services.DataService
{
    public class DataServiceTests
    {
        [Fact]
        public void DataService_GetBoxes_Should_Return_Valid_Containers_With_Count_3()
        {
            //arrange
            var ser = GetDataService();

            //act 
            var result = ser.GetBoxes();

            //assert  
            result.Count().Should().Be(3);
        }
        private ChallengeApp.Services.DataService.DataService GetDataService()
        {
            return new ChallengeApp.Services.DataService.DataService();
        }
    }
}
