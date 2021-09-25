using System.Collections.Generic;

namespace Stratis.ChallengeApp.Tests.FakeData
{
    public class ContainerFake
    {
        public List<Models.Container> GetContainersList()
        {
            return new List<Models.Container>
            {
                new Models.Container {Id=  0, Name = "Red", Weight = 3, Size= 4, Quantity =3},
                new Models.Container {Id = 1, Name = "Green", Weight = 4, Size= -3, Quantity =3},
                new Models.Container {Id = 2, Name = "Blue", Weight = -6, Size= 6, Quantity =3}
            };
        }
    }
}
