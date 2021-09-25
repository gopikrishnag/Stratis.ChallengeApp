using System.Collections.Generic;

namespace Stratis.ChallengeApp.Services.DataService
{
    public interface IDataService
    {
        public List<Models.Container> GetBoxes();
    }
}
