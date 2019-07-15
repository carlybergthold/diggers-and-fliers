using System.Collections.Generic;

namespace Animals
{
    public class SwimmersContainer
    {
        public List<ISwimming> swimmers { get; set; }
        public SwimmersContainer()
        {
            this.swimmers = new List<ISwimming>();
        }
    }
}