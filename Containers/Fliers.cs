using System.Collections.Generic;

namespace Animals
{
    public class FlyerContainer
    {
        public List<IFlying> Fliers { get; set; }
        public FlyerContainer()
        {
            this.Fliers = new List<IFlying>();
        }
    }
}