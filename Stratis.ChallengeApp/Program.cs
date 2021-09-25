using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stratis.ChallengeApp.Constants;
using Stratis.ChallengeApp.Helpers;
using Stratis.ChallengeApp.Services.DataService;
using Stratis.ChallengeApp.Services.SimulationService;
using System;
using System.Threading.Tasks;

namespace Stratis.ChallengeApp
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();

            Console.WriteLine(GlobalConstants.UserInputUserMessage);
            var input = Console.ReadLine();
            var validInput = input.ValidateUserInput();

            if (validInput)
            {
                _ = SimulationServiceWithDependencyInjection(host.Services, input);
            }
            else
            {
                Console.WriteLine(GlobalConstants.UserInputUserWarningMessage);
            }
            return host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services
                       .AddTransient<ISimulationService, SimulationService>()
                       .AddTransient<IDataService, DataService>()); 
        }

        public static async Task SimulationServiceWithDependencyInjection(IServiceProvider services, string input)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;
            var simulation = provider.GetRequiredService<ISimulationService>();

            for (int i = 0; i < int.Parse(input); i++)
            {
                var userMsg = simulation.SimulationSummary();
                await Task.Delay(GlobalConstants.TimeDelay);
                Console.WriteLine(userMsg);
            }
            Console.WriteLine(GlobalConstants.UserInputUserInfomationMessage);

        }


    }
}
