using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Stratis.ChallengeApp.Services.SimulationService;
using System;
using Xunit;

namespace Stratis.ChallengeApp.Tests
{
    public class ProgramTests
    {
        private readonly IServiceProvider _serviceProvider;

        public ProgramTests()
        {
            var serviceProvider = new Mock<IServiceProvider>();
            serviceProvider.Setup(x => x.GetService(typeof(ISimulationService))).Returns(Mock.Of<ISimulationService>());

            var serviceScope = new Mock<IServiceScope>();
            serviceScope.Setup(x => x.ServiceProvider).Returns(serviceProvider.Object);

            var serviceScopeFactory = new Mock<IServiceScopeFactory>();
            serviceScopeFactory.Setup(x => x.CreateScope()).Returns(serviceScope.Object);

            serviceProvider.Setup(x => x.GetService(typeof(IServiceScopeFactory))).Returns(serviceScopeFactory.Object);

            _serviceProvider = serviceProvider.Object   ;
        }

        [Fact(Skip ="need to fix")]
        public void SimulationServiceWithDependencyInjection_Should_Return_Summary_Message()
        {
            var result =  Program.SimulationServiceWithDependencyInjection(_serviceProvider, "10");
            result.Should().Be("service is working");
            }
        }
}