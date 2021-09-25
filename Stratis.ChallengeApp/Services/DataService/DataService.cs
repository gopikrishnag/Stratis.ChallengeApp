using System.Collections.Generic;

namespace Stratis.ChallengeApp.Services.DataService
{
    public class DataService : IDataService
    {
        public   List<Models.Container> GetBoxes()
        {
            var boxes = new List<Models.Container>
            {
                new Models.Container {Id=  0, Name = "Red", Weight = 5, Size= 2, Quantity =5},
                new Models.Container {Id = 1, Name = "Green", Weight = 1, Size= -8, Quantity =5},
                new Models.Container {Id = 2, Name = "Blue", Weight = -3, Size= 4, Quantity =5}
            };

            return boxes;
        }
    }
}
