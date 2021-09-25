using NSubstitute;
using Stratis.ChallengeApp.Tests.FakeData;
using Xunit;

namespace Stratis.ChallengeApp.Tests.Services.SimulationService
{
    public  class SimulationServiceTests: IClassFixture<ContainerFake>
    {
        private readonly ContainerFake _containerFake;
        private readonly ChallengeApp.Services.DataService.DataService _mockDataService = Substitute.For<ChallengeApp.Services.DataService.DataService>();


        public SimulationServiceTests(ContainerFake containerFake)
        {
            _containerFake = containerFake;
        }

        [Fact]
        public void SimulationService_SimulationSummary_Should_Return_Valid_Summary()
        {
            //arrange
            var ser = GetSimulationService();

            //act 
            var result = ser.SimulationSummary();

            //assert  
            result.Contains("Total  Weight");
        }
        private ChallengeApp.Services.SimulationService.SimulationService GetSimulationService()
        {
            return new ChallengeApp.Services.SimulationService.SimulationService(_mockDataService);
        }
    }
}
