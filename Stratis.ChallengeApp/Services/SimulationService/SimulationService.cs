using Stratis.ChallengeApp.Services.DataService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stratis.ChallengeApp.Services.SimulationService
{
    public class SimulationService : ISimulationService
    {
        private readonly Random _random = new Random();
        private readonly List<Models.Container> _totalBox = new List<Models.Container>();
        private readonly IDataService _dataService;

        public SimulationService(IDataService dataService)
        {
            _dataService = dataService;
        }

         
        public string SimulationSummary()
        {
            var listOfBoxes = _dataService.GetBoxes();
            var randomNumber = _random.Next(listOfBoxes.Count);
            var randomBox = listOfBoxes.FirstOrDefault(a => a.Id == randomNumber);
            _totalBox.Add(randomBox);

            return $"Total  Weight : {_totalBox.Sum(a => a.Weight)}  Size : {_totalBox.Sum(a => a.Size)} Quantity  {_totalBox.Sum(a => a.Quantity)}";
        }
    }
}
