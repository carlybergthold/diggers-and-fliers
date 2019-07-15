using System.Collections.Generic;

namespace Animals
{
    public class WalkersContainer
    {
        public List<IWalking> walkers { get; set; }
        public WalkersContainer()
        {
            this.walkers = new List<IWalking>();
        }
    }
}